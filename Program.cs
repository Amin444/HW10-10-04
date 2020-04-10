using System;

namespace HW10_10_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string ProPassword ="Key_Document-TXT";
            string ExpPassword = "Exp-Doc_j7HH";
            while(true)
            {
            System.Console.Write("enter Pro Version or Exp Version:");
            string access = Console.ReadLine();
            System.Console.WriteLine("   ");
            System.Console.WriteLine("Вы ввели не верный пароль тфк что пока пользуйтесь бесплатной версией )))");           
            if(access==ProPassword)
            {
                 ProDocumentWorker p= new ProDocumentWorker();
                p.EditDocument();
                p.SaveDocument();
            }
            else if(access==ExpPassword)
            {
                     ExpertDocumentWorker E =new ExpertDocumentWorker();
                     E.SaveDocument();
            }
            else
            {
                Documentworker d=new Documentworker();
                d.OpenDocument();
                d.SaveDocument();
                d.EditDocument();
            }
            
             System.Console.WriteLine("Если вы нажмете на '1' то вы зайдете на параметры Player\n Если же хотите увидеть RecordPlayer нажмите '3' ");
                var s=int.Parse(Console.ReadLine());
                if(s==1)
                {
                  Player P=new Player();
                    P.Pause();
                    P.Play();
                    P.stop();
                   
                }
               else if(s==3)
                {
                    RecordPlay R =new RecordPlay();
                     R.Pause();
                     R.Record();
                     R.Stop();
                   

                }
                else if(s!=1|| s!=3)
                 {
                     System.Console.WriteLine("Error! Вы не ввели ни одну из перечисленых команд \n пожалуста введите ''1 или '3'");
                 }
            Console.ReadKey();
              

        }
    }
    class Documentworker
    {
        public virtual void OpenDocument()
        {
                System.Console.WriteLine("Документ открыт");
               
        }
        public virtual void EditDocument()
        {
                System.Console.WriteLine("Редактирование документа доступно вверсии Про");
        }
        public virtual void SaveDocument()
        {
                System.Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
    class ProDocumentWorker:Documentworker
    {
          public override void EditDocument()
        {
                System.Console.WriteLine("Документ сохранен в старом формате");
        }
         public override void SaveDocument()
        {
                System.Console.WriteLine( "сохранение в остальных форматах доступно в версии Эксперт");
        }

    }
    class ExpertDocumentWorker:ProDocumentWorker
    {
        public override void SaveDocument()
        {
            System.Console.WriteLine("Документ сохранен в новом формате");
        }
       
    }

    interface IPalayer
    {
         void Play();
         void Pause();
         void stop();
    }
    interface IRecodable
    {
           void Record();
           void Pause();
            void Stop();
    }
    class Player : IPalayer
    {
        public void Pause()
        {
            System.Console.WriteLine("остановить");
        }

        public void Play()
        {
            System.Console.WriteLine("играть");
        }

        public void stop()
        {
            System.Console.WriteLine("прекратить какое то");
        }
    }
    class RecordPlay : IRecodable
    {
       public void Pause()
    {
        Console.WriteLine("I've paused music");
    }

    public void Stop()
    {
        Console.WriteLine("I've stopped music");
    }
    public void Record()
    {
        Console.WriteLine("I'm recording");
    }
    

  }
}

}










