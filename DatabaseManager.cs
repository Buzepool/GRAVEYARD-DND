using Cemitério_DND;
using System.Data.SQLite;

public class DatabaseManager
{
    private readonly string connectionString;

    public DatabaseManager()
    {
        connectionString = "Data Source=characters.db";
    }

    public List<Character> GetCharacters()
    {
        var characters = new List<Character>();

        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            var command = new SQLiteCommand("SELECT Name, Class, Level FROM Characters", connection);

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    characters.Add(new Character(
                        reader["Name"].ToString(),
                        reader["Class"].ToString(),
                        reader["Level"].ToString()));
                }
            }
        }

        return characters;
    }

    public void AddCharacter(Character character)
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            var command = new SQLiteCommand("INSERT INTO Characters (Name, Class, Level) VALUES (@Name, @Class, @Level)", connection);
            command.Parameters.AddWithValue("@Name", character.Name);
            command.Parameters.AddWithValue("@Class", character.Class);
            command.Parameters.AddWithValue("@Level", character.Level);

            command.ExecuteNonQuery();
        }
    }

    public void RemoveCharacter(Character character)
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            var command = new SQLiteCommand("DELETE FROM Characters WHERE Name = @Name", connection);
            command.Parameters.AddWithValue("@Name", character.Name);

            command.ExecuteNonQuery();
        }
    }
}
