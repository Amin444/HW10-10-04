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
            Console.ReadKey();
            }   

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
        public void Play()
        {

        }
        public void Pause()
        {

        }
        public void stop()
        {

        }
    }
    interface IRecodable
    {
           void Record();
           void Pause();
            void Stop();
    }
     
        

        
     


        class Player:IPalayer
        {

        }

         class Player1:IRecodable  
         {

         }
}
