using Cemitério_DND;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

public class DatabaseManager
{
    private readonly string connectionString;

    public DatabaseManager()
    {
        connectionString = "Data Source=characters.db";
        InitializeDatabase();
    }

    private void InitializeDatabase()
    {
        try
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Exemplo: criação da tabela se ela não existir
                var command = new SQLiteCommand(
                    "CREATE TABLE IF NOT EXISTS Characters (Name TEXT, Class TEXT, Level INTEGER)",
                    connection);
                command.ExecuteNonQuery();
            }
        }
        catch (SQLiteException ex)
        {
            Console.WriteLine($"SQLite Exception on database initialization: {ex.Message}");
            // Handle or log the exception as needed
        }
    }

    public List<Character> GetCharacters()
    {
        var characters = new List<Character>();

        try
        {
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
        }
        catch (SQLiteException ex)
        {
            Console.WriteLine($"SQLite Exception: {ex.Message}");
            // Handle or log the exception as needed
        }

        return characters;
    }

    public void AddCharacter(Character character)
    {
        try
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
        catch (SQLiteException ex)
        {
            Console.WriteLine($"SQLite Exception: {ex.Message}");
            // Handle or log the exception as needed
        }
    }

    public void RemoveCharacter(Character character)
    {
        try
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("DELETE FROM Characters WHERE Name = @Name", connection);
                command.Parameters.AddWithValue("@Name", character.Name);

                command.ExecuteNonQuery();
            }
        }
        catch (SQLiteException ex)
        {
            Console.WriteLine($"SQLite Exception: {ex.Message}");
            // Handle or log the exception as needed
        }
    }
}
