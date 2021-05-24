using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>() // first we create out list of emojis
            {
                "🐼", "🐼", //panda
                "🦁", "🦁", // Lion
                "🐵", "🐵", // Monkey
                "🦒", "🦒", // Giraffe
                "🦝", "🦝", // Racoon
                "🦊", "🦊", // Fox
                "🐶", "🐶", // dog
                "🐱", "🐱", // cat
            };
            Random random = new Random();

            foreach(TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(animalEmoji.Count); // this will get us a random element of the list
                string nextEmoji = animalEmoji[index]; //this will grab our emoji and store it in a string
                textBlock.Text = nextEmoji; //  this will store the store the previous string into the Text section of textBlock
                animalEmoji.RemoveAt(index); // this will remove the emoji we have just used so we cannot use it again.
            }
        }
    }
}
