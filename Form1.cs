namespace Cemitério_DND
{
    public partial class Form1 : Form
    {
        private DatabaseManager databaseManager;
        public List<Character> Characters { get; private set; } = new List<Character>();

        public Form1()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
            LoadCharacters();
        }

        private void LoadCharacters()
        {
            Characters = databaseManager.GetCharacters();
            foreach (var character in Characters)
            {
                ls_characters.Items.Add(new ListViewItem(new string[] { character.Name, character.Class, character.Level.ToString() }));
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                var name = txt_name.Text;
                var @class = txt_class.Text;
                var level = txt_nvl.Text;

                foreach (Character character in Characters)
                {
                    if (character.Name == name)
                    {
                        MessageBox.Show(name + " This character is already in the graveyard");
                        return;
                    }
                }

                var newCharacter = new Character(name, @class, level);
                Characters.Add(newCharacter);
                databaseManager.AddCharacter(newCharacter);

                ls_characters.Items.Add(new ListViewItem(new string[] { name, @class, level }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (ls_characters.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a character to delete.");
                return;
            }

            var selectedItem = ls_characters.SelectedItems[0];
            var characterName = selectedItem.SubItems[0].Text;

            var character = Characters.FirstOrDefault(c => c.Name == characterName);
            if (character != null)
            {
                Characters.Remove(character);
                databaseManager.RemoveCharacter(character);
                ls_characters.Items.Remove(selectedItem);
                MessageBox.Show(characterName + " The character as been removed from graveyard.");
            }
            else
            {
                MessageBox.Show("Character not found");
            }
        }
    }
}
