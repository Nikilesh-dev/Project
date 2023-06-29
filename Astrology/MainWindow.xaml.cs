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

namespace Astro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            object Name = txtName.Text;
            int Year = Convert.ToInt32(txtBirthDate.Text);

            int CurrentYear = 2023;
            int Age = CurrentYear - Year;
            

          Content.Content= Astrology(Name.ToString(), Age).ToString();

            //Content.Text = Age.ToString();

        }

        private object Astrology(String Name, int Age)
        {
            Char[] Name1 = Name.ToCharArray();
            
            StringBuilder stringBuilder = new StringBuilder();

            if ((Name1[0] == 'A' && Age <= 18) || (Name[0] == 'H' && Age >= 59) || (Name[0] == 'U' && (Age >= 18 && Age <= 58))) {

                stringBuilder.Append("Hai  " + Name + " Your Age is  " + Age + System.Environment.NewLine + "Power and spirituality define You. Your dynamism has a touch of decisiveness. " + System.Environment.NewLine +
                    "That is why You make good counsellors." + System.Environment.NewLine +
                    "You are protective and are sacrificing." + System.Environment.NewLine +
                    "These sensitive souls thrive on love, affection, and friendship. Your stubbornness leads You to aggressiveness and extremism.");

                return stringBuilder.ToString();
            } 
            if ((Name[0] == 'A' && Age >= 18 && Age <= 58) || (Name[0] == 'I' && Age >= 59) || (Name[0] == 'R' && (Age >= 18 && Age <= 58))) {
                stringBuilder.Append("Hai  " + Name + " Your Age is  " + Age + System.Environment.NewLine + "These people have an honest, loyal, peace-loving, spiritual and sensitive outlook." + System.Environment.NewLine +
                    "Despite being friendly, understanding and observing, these talented people are secretive, moody and quarrelsome.");
                return stringBuilder.ToString();

            }
            if ((Name[0]=='A' && Age >= 59) || (Name[0] == 'H' && (Age >= 18 && Age <= 58)) || (Name1[0] == 'V' && Age <= 18) || (Name[0] == 'Y' && Age >= 59))
            {
                stringBuilder.Append("Hai  " + Name + " Your Age is  " + Age + System.Environment.NewLine + "You are naturally intuitive. These inspiring people are optimistic and mischievous." + System.Environment.NewLine + "Your strength supports your administrational qualities." + System.Environment.NewLine + "You can be expressive and outspoken.");
                return stringBuilder.ToString();
            }
        
            if((Name1[0] == 'B' && Age <= 18) || (Name[0] == 'J' && Age >= 59) || (Name1[0] == 'T' && Age <= 18) || (Name[0] == 'U' && Age >= 59))
            {

                stringBuilder.Append("Hai  " + Name + " Your Age is  " + Age + System.Environment.NewLine + " Bold, determined, authoritative and diligent workers."+ System.Environment.NewLine +
                    "You get popular in their practicality, orderliness and unassuming manner. " + System.Environment.NewLine +
                    "While being opinionated gets worse with stubbornness, Your shrewdness is their double-edged sword.");

                return stringBuilder.ToString();
            }
            if ((Name[0] == 'B' && (Age >= 18 && Age <= 58)) || (Name[0] == 'H' && Age <= 18) || (Name[0] == 'R' && Age <= 58) || (Name[0] == 'W' && Age >= 18 && Age <= 58))
            {
                stringBuilder.Append("Hai  " + Name + " Your Age is  " + Age + System.Environment.NewLine + "You have a sense of spirituality and perceptiveness. Passion and versatility meet ambitions. " + System.Environment.NewLine +
                    "Your restless & free nature gives wings to their wanderlust. " + System.Environment.NewLine +
                    "Your personality has a dual & secretive nature. " + System.Environment.NewLine +
                    "A friendly nature supports these originally born entertainers.");
                return stringBuilder.ToString();

            }
             if ((Name[0] == 'B' && Age >= 59) || (Name[0] == 'I' && Age >= 18 && Age <= 58) || (Name1[0] == 'R' && Age <= 18) || (Name[0] == 'V' && Age >= 59))
            {
                stringBuilder.Append("Hai  " + Name + " Your Age is  " + Age + System.Environment.NewLine + "You are naturally intuitive. These inspiring people are optimistic and mischievous." + System.Environment.NewLine + "Yourr strength supports your administrational qualities." + System.Environment.NewLine + "You can be expressive and outspoken.");
                return stringBuilder.ToString();
            }
            if ((Name1[0] == 'C' && Age <= 18) || (Name1[0] == 'I' && Age <= 18) || (Name[0] == 'Q' && (Age >= 18 && Age <= 58)) || (Name1[0] == 'Y' && Age <= 18))
            {

                stringBuilder.Append("Hai  " + Name + " Your Age is  " + Age + System.Environment.NewLine + "Your courage, strength and confidence are impressive, like your goal-oriented, self-sacrificing and responsible stance. " + System.Environment.NewLine +
                    "These warm, loyal and god-fearing people handle administration well." + System.Environment.NewLine +
                    "You can be melancholic. Many hate their stubborn and interfering temperament.");

                return stringBuilder.ToString();
            }
            if ((Name[0] == 'C' && (Age >= 18 && Age <= 58)) || (Name[0] == 'J' && Age >= 18) || (Name1[0] == 'S' && Age <= 18) || (Name1[0] == 'U' && Age <= 18))
            {
                stringBuilder.Append("Hai  " + Name + " Your Age is  " + Age + System.Environment.NewLine + "They have a sense of spirituality and perceptiveness. Passion and versatility meet ambitions. " + System.Environment.NewLine +
                    "Your restless & free nature gives wings to their wanderlust. " + System.Environment.NewLine + 
                    "Your personality has a dual & secretive nature. " + System.Environment.NewLine +
                    "A friendly nature supports these originally born entertainers.");
                return stringBuilder.ToString();

            }
            if ((Name[0] == 'C' && Age >= 59) || (Name[0] == 'J' && (Age >= 18 && Age <= 58)) || (Name[0] == 'S' && Age >= 59) || (Name[0] == 'V' && Age >= 18 && Age <= 58))
            {
                stringBuilder.Append("Hai  " + Name + " Your Age is  " + Age + System.Environment.NewLine + "Your determined and confident  work methodically." + System.Environment.NewLine +
                    "Your affectionate, self-sacrificing & tolerant nature makes them pleasant." + System.Environment.NewLine +
                    "Despite lazy thinking and distrust, these innovative and introspective visionaries are clairvoyants.");
                return stringBuilder.ToString();
            }
            if ((Name1[0] == 'D' && Age <= 18) || (Name[0] == 'O' && Age >= 59) ||  (Name1[0] == 'Q' && Age <= 18) || (Name[0] == 'X' && Age >= 59))
            {

                stringBuilder.Append("Hai  " + Name + " Your Age is  " + Age + System.Environment.NewLine + "These well-balanced people can be caring and excellent organisers." + System.Environment.NewLine +
                    "Though creative and original, cautiousness makes You sceptics. Your self-indulgence is unpleasant." + System.Environment.NewLine +
                    "Despite being intuitive and independent, self-doubt and money mishandling gets You.");

                return stringBuilder.ToString();
            }
            if ((Name[0] == 'D' &&( Age >= 18 && Age <=58)) ||(Name[0] == 'K' && Age >= 59) || (Name[0] == 'S' && (Age >= 18 && Age <= 58)) || (Name1[0] == 'Z' && Age <= 18))
            {
                stringBuilder.Append("Hai  " + Name + " Your Age is  " + Age + System.Environment.NewLine + "These expressive and hardworking individuals live an emotional and considerate life." + System.Environment.NewLine +
                    "Your good taste has an artistic touch. Your are a steadfast idealist." + System.Environment.NewLine +
                    "These impulsive and deep-thinking romantics can be overdramatic too.");
                return stringBuilder.ToString();

            }
            if ((Name[0] == 'D' && Age >= 59) || (Name1[0] == 'K' && Age <= 18) || (Name[0] == 'T' && (Age >= 18 && Age <= 58)) || (Name[0] == 'Z' && (Age >= 18 && Age <= 58)))
            {
                stringBuilder.Append("Hai  " + Name + " Your Age is  " + Age + System.Environment.NewLine + "These dignified individuals are friendly, honest, and reliable." + System.Environment.NewLine +
                    "Though indecisive, Your originality, enthusiasm and self-confidence are their saving grace." + System.Environment.NewLine +
                    "These talented and intelligent people make good administrators." + System.Environment.NewLine +
                    "Of course, Your extreme nature and ego are unbearable.");
                return stringBuilder.ToString();
            }
            if ((Name1[0] == 'E' && Age <= 18) || (Name[0] == 'K' && (Age >= 18 && Age <= 58)) || (Name1[0] == 'P' && Age <= 18) || (Name[0] == 'X' && Age <= 18))
            {

                stringBuilder.Append("Hai  " + Name + " Your Age is  " + Age + System.Environment.NewLine + "Such helpful and popular individuals have a creative and popular streak. Many trusts Your intuition." + System.Environment.NewLine +
                    "These emotional and protective beings live in an imaginary and nervous world.");

                return stringBuilder.ToString();
            }
            if ((Name[0] == 'E' && Age >= 18) || (Name1[0] == 'L' && Age <= 18) || (Name[0] == 'P' && (Age >= 18 && Age <= 58)))
            {
                stringBuilder.Append("Hai  " + Name + " Your Age is  " + Age + System.Environment.NewLine + "These intelligent folks are quite determined and hardworking." + System.Environment.NewLine +
                    "Good memory makes them great taskmasters and achievers." + System.Environment.NewLine +
                    "Your honest nature comes with generosity and friendliness." + System.Environment.NewLine +
                    "These emotional travellers seek adventure.");
                return stringBuilder.ToString();

            }
            if ((Name[0] == 'E' && Age >= 59) || (Name[0] == 'L' && (Age >= 18 && Age <= 58)) || (Name1[0] == 'O' && Age <= 18) || (Name[0] == 'Y' && (Age >= 18 && Age <= 58)))
            {
                stringBuilder.Append("Hai  " + Name + " Your Age is  " + Age + System.Environment.NewLine + "Such people are hugely reputed to be intelligent, industrious, and responsible." + System.Environment.NewLine +
                    "Your aesthetic and practical nature makes them good organisers. " + System.Environment.NewLine +
                    "Your strong-will nature leads them to stubbornness." + System.Environment.NewLine +
                    "Such shrewd people have a moody side and worry a lot, apart from dealing with life’s changes.");
                return stringBuilder.ToString();
            }
            if ((Name1[0] == 'F' && Age <= 18) || (Name[0] == 'L' && Age >= 59) || (Name1[0] == 'T' && Age <= 18) || (Name[0] == 'W' && Age >= 59))
            {

                stringBuilder.Append("Hai  " + Name + " Your Age is  " + Age + System.Environment.NewLine + " One can call them creatively unconventional. They are powerful, sympathetic and intuitive." + System.Environment.NewLine +
                    "They do not win hearts easily courtesy of their extreme moods. " + System.Environment.NewLine +
                    "Your opinionated nature is disadvantageous. " + System.Environment.NewLine +
                    "These pleasure-seekers face health issues and can repeat mistakes.");

                return stringBuilder.ToString();
            }
            if ((Name[0] == 'F' && (Age >= 18 && Age <= 58)) || (Name[0] == 'M' && Age >= 59) || (Name[0] == 'N' && (Age >= 18 && Age <= 58)))
            {
                stringBuilder.Append("Hai  " + Name + " Your Age is  " + Age + System.Environment.NewLine + "Characterised by their patience, willpower, and skillfulness, they have an aesthetic side." + System.Environment.NewLine +
                    "Your financial knowledge is respectable, while their conservative nature overwhelms them." + System.Environment.NewLine +
                    "Despite jealousy & moodiness, these emotional individuals are high on morals and privacy.");
                return stringBuilder.ToString();

            }
            if ((Name[0] == 'F' && Age >= 59) || (Name1[0] == 'F' && Age <= 18) || (Name[0] == 'Q' && Age >= 59) || (Name[0] == 'Z' && Age >= 59))
            {
                stringBuilder.Append("Hai  " + Name + " Your Age is  " + Age + System.Environment.NewLine + "Spiritualism defines them." + System.Environment.NewLine +
                    "These good orators utilise their talents and intelligence. Their generosity borders on squandering. " + System.Environment.NewLine +
                    "Skilled at administration, their level-headedness and clarity are impressive. " + System.Environment.NewLine +
                    "Your aloof nature makes them secretive. They are fearless yet impatient individuals.");
                return stringBuilder.ToString();
            }
            if ((Name1[0] == 'G' && Age <= 18) || (Name[0] == 'M' && (Age >= 18 && Age <= 58)) || (Name[0] == 'O' && (Age >= 18 && Age <= 58)))
            {

                stringBuilder.Append("Hai  " + Name + " Your Age is  " + Age + System.Environment.NewLine + "These dreamers have an outspoken and authoritative nature. They are eternally doubtful and confused." + System.Environment.NewLine +
                    "Your mysterious behaviour creates misunderstanding and gossip." + System.Environment.NewLine +
                    "These talkative people are excellent orators." + System.Environment.NewLine +
                    "Your unstable existence swings between the physical and spiritual world.");

                return stringBuilder.ToString();
            }
            if ((Name[0] == 'G' && (Age >= 18 && Age <= 58)) || (Name1[0] == 'N' && Age <= 18) || (Name[0] == 'P' && Age >= 59))
            {
                stringBuilder.Append("Hai  " + Name + " Your Age is  " + Age + System.Environment.NewLine + "The inspiring folks live a lively and ambitious life, despite bad memory. " + System.Environment.NewLine +
                    "These confident and emotional people use their inborn understanding and gentle nature to help others." + System.Environment.NewLine +
                    "You believe in hard work, perseverance, and sacrifice." + System.Environment.NewLine +
                    "Your critical and non-tolerant nature is unacceptable.");
                return stringBuilder.ToString();

            }
            if ((Name[0] == 'G' && Age >= 59) || (Name[0] == 'N' && Age >= 59) || (Name1[0] == 'W' && Age <= 18) || (Name[0] == 'X' && (Age >= 18 && Age <= 58)))
            {
                stringBuilder.Append("Hai  " + Name + " Your Age is  " + Age + System.Environment.NewLine + "Such people are naturally vocal and passionate." + System.Environment.NewLine +
                    "Your charismatic nature is influential, though their moodiness is offensive. " + System.Environment.NewLine +
                    "You are emotional, devoted and loving." + System.Environment.NewLine +
                    "You notice them enthusiastically encourage others, despite dualism and extremism. They always work on their success and self-esteem.");
                return stringBuilder.ToString();
            }





            return "Enter Valid Details";

            
        }
    }
}
