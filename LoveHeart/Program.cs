using System;

namespace LoveHeart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define all our views
            var loginView = new LoginView();
            var receptionistMainView = new ReceptionistMainView();
            var veterinaryMainView = new VeterinaryMainView();
            // adminview
            // add pet view
            // .. 

            var input = loginView.GetInput();

            ConsoleView activeView;

            switch (input)
            {
                case "receptionistView":

                    activeView = receptionistMainView;
                    break;

                case "receptionistView":

                    activeView = veterinaryMainView;

                    break;

                default:

                    activeView = loginView;

                    break;

            }

            activeView.Dislay();
        }

        class LoginView : ConsoleView
        {
            public override void Display()
            {
                throw new NotImplementedException();
            }

            public override void GetInput()
            {
                throw new NotImplementedException();
            }
        }

        class ReceptionistMainView : ConsoleView
        {
            public override void Display()
            {
                throw new NotImplementedException();
            }
            public override void GetInput()
            {
                throw new NotImplementedException();
            }

        }

        class VeterinaryMainView : ConsoleView
        {
            public override void Display()
            {
                throw new NotImplementedException();
            }

            public override void GetInput()
            {
                throw new NotImplementedException();
            }
        }

        abstract class ConsoleView
        {
            public abstract void Display();

            public abstract void GetInput();
        }
    }
}
