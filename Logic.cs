using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompleteAssignment1
{
    public class Logic
    {

        int Bl = 0;
        int Ch = 2;
        int SBl = 7;
        int Sr = 0;
        public void Load()
        {
            //Place Bullet in random location 
            Random rand = new Random();
            int Var1 = rand.Next(1, 6);
            Bl = Var1;
            MessageBox.Show("Bullet Loaded");
        }
        public void Spin()
        {
            //Spin and make random location for shoot gun
            Random rand = new Random();
            int Var1 = rand.Next(1, 6);
            SBl = Var1;
            MessageBox.Show("Spinned");
        }
        public void StartAgain()
        {
            //Reset all properties and start a fresh game
            Bl = 0;
            Ch = 2;
            SBl = 7;
            Sr = 0;
            MessageBox.Show("Game Started");
        }
        public void Shoot()
        {
            //if I have chances
            if (Ch > 0)
            {
                //Gun Shoot Sound
                SoundPlayer sound = new SoundPlayer(CompleteAssignment.Properties.Resources.Shoot);
                sound.Play();

                //Bullet and Spin Chamber location Same then win game
                if (Bl == SBl)
                {
                    Sr =Sr + 10;
                    MessageBox.Show("Congratulations. You survived . \nYour Score : " + Sr + (Sr == 10 ? "\n \nYou Won the Game" : "\nYou Loss the Game"));
                    Ch = 0;
                }
                else
                {
                    MessageBox.Show("The revolver just rotated");
                    SBl += 1;
                    Sr -= 1;
                }
            }
            //If I don't have any chances left
            else
            {
                MessageBox.Show("You are dead! \nGame End\n Your Score : " + Sr + "\n You Loss Game");
            }

            Ch = Ch - 1;
        }
    }
}
