using System;

namespace DojoDachi {
    public class DojoDachi {
        public int Meal;
        public int Happiness;
        public int Energy;
        public int Fullness;

        public DojoDachi () {
            Meal = 3;
            Happiness = 20;
            Energy = 50;
            Fullness = 20;
        }

        public void EatMeal () {
            Random rand = new Random ();
            int food = rand.Next (5, 10);
            Fullness += food;
            int num = rand.Next (1, 5);
            if (num == 1) {
                Meal -= 1;
            } else {
                Meal += food;
                Meal -= 1;
            }
        }
        public void Playing () {
            Random rand = new Random ();
            int play = rand.Next (5, 10);
            int num = rand.Next (1, 5);
            if (num == 1) {
                Energy -= 5;
            } else {
                Happiness += play;
                Energy -= 5;
            }
        }
        public void Working () {
            Random rand = new Random ();
            int work = rand.Next (5, 10);
            Energy -= 5;
            Meal += work;
        }
        public void Sleeping () {
            Energy += 15;
            Fullness -= 5;
            Happiness -= 5;
        }
        public void Restart () {
            Meal = 3;
            Happiness = 20;
            Energy = 50;
            Fullness = 20;
        }
        public bool HasWon () {
            if (Fullness >= 100 && Happiness >= 100 && Energy >= 100) {
                return true;
            } else {
                return false;
            }
        }
        public bool HasDied () {
            if (Energy <= 0 || Happiness <= 0) {
                return true;
            } else {
                return false;
            }
        }
    }
}