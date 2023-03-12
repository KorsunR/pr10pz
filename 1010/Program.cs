using static proklyatye.Program;

namespace proklyatye
{
    internal class Program
    {
        public enum roule { Админ, Кассир, Менеджерперсонала, Кладовщик, Бухгалтер }
        public enum key { zerokey, UpArrow, DownArrow, LeftArrow, RightArrow, Escape, Enter, F1, F2, F10, S }
        static user curentuser;
        static List<user> split = new List<user>();
        static List<people> urod = new List<people>();
        static List<goods> chpoks = new List<goods>();

        public struct user
        {
            public int id;
            public string login;
            public string password;
            public roule roule;
        }
        public struct people
        {
            public int id;
            public string famelename;
            public string name;
            public string fathername;
            public string numberpassport;
            public roule roule;
            public int salary;
        }
        public struct goods
        {
            public int id;
            public string name;
            public int cost;
            public int quantity;
        }
        internal interface Icrud
        {
            public void create();
            public void read();
            public void update();
            public void delete();
            public void find();
        }

        public class admin : Icrud
        {
            menu menuadm;
            public bool stupid()
            {
                Console.SetCursorPosition(Console.WindowLeft / 2, Console.WindowTop / 2);
                Console.WriteLine("Хотите ли вы сделать это? y/n");
                ConsoleKeyInfo cki;
                do
                {
                    cki = Console.ReadKey();
                } while ((cki.Key != ConsoleKey.Y) && (cki.Key != ConsoleKey.N));
                if (cki.Key != ConsoleKey.Y) { return true; } else { return false; }
            }

            public void create()
            {
                user adr = new user();
                menuadm.clearshow();
                Console.Write("Логин - "); adr.login = Console.ReadLine();
                Console.Write("Пароль - "); adr.password = Console.ReadLine();
                Console.Write("roule (0-4) - "); ConsoleKeyInfo cki = Console.ReadKey();
                
                throw new NotImplementedException();
            }

            public void read()
            {
                menuadm.clearshow();
                menuadm.usertolist(split[menuadm.lastpos]);
                menuadm.show();

                
            }

            public void update()
            {
                menuadm.clearshow();
                menuadm.usertolist(split[menuadm.lastpos]);
                if (menuadm.main() == 6)
                {
                    Console.SetCursorPosition(menuadm.startcol, menuadm.startrow + menuadm.newpos);
                    
                };

                
            }

            public void delete()
            {
                if (stupid())
                {
                    menuadm.clearshow();
                    split.RemoveAt(menuadm.lastpos);
                    menuadm.userstolist();
                }

                
            }

            public void find()
            {
                throw new NotImplementedException();
            }

            public admin()
            {
                
                Console.Clear();
                Console.WriteLine(curentuser.login);
                menuadm = new menu();
                int i;
                menuadm.userstolist();
                do
                {
                    i = menuadm.main();
                    switch (i)
                    {
                        case 5: break;//escape
                        case 6: read(); break;//enter (read)
                        case 7: create(); break;//f1
                        case 8: update(); break; //f2
                        case 9: delete(); break;
                        case 10: break;
                    }
                } while (i != 5);
            }
        }
        public class cashier : Icrud
        {
            public void create()
            {
                throw new NotImplementedException();
            }

            public void delete()
            {
                throw new NotImplementedException();
            }

            public void find()
            {
                throw new NotImplementedException();
            }

            public void read()
            {
                throw new NotImplementedException();
            }

            public void update()
            {
                throw new NotImplementedException();
            }
        }
        public class personnel : Icrud
        {
            menu menuadm;
            public bool stupid()
            {
                Console.SetCursorPosition(Console.WindowLeft / 2, Console.WindowTop / 2);
                Console.WriteLine("Хотите ли вы сделать это? y/n");
                ConsoleKeyInfo cki;
                do
                {
                    cki = Console.ReadKey();
                } while ((cki.Key != ConsoleKey.Y) && (cki.Key != ConsoleKey.N));
                if (cki.Key != ConsoleKey.Y) { return true; } else { return false; }
            }

            public void create()
            {
                people cringe = new people();
                menuadm.clearshow();
                Console.Write("Имя - "); cringe.name = Console.ReadLine();
                Console.Write("Фамилия - "); cringe.famelename = Console.ReadLine();
                Console.Write("Номер паспорта - "); cringe.numberpassport = Console.ReadLine();
                
                Console.Write("roule (0-4) - "); ConsoleKeyInfo pimp = Console.ReadKey();
                
            }

            public void delete()
            {
                if (stupid())
                {
                    menuadm.clearshow();
                    urod.RemoveAt(menuadm.lastpos);
                    menuadm.piplstolist();
                }

                
            }

            public void find()
            {
                throw new NotImplementedException();
            }

            public void read()
            {
                menuadm.clearshow();
                menuadm.usertolist(split[menuadm.lastpos]);
                menuadm.show();

                
            }

            public void update()
            {
                throw new NotImplementedException();
            }
            public personnel()
            {
                
                Console.Clear();
                Console.WriteLine(curentuser.login);
                menuadm = new menu();
                int i;
                menuadm.piplstolist();
                do
                {
                    i = menuadm.main();
                    switch (i)
                    {
                        case 5: break;//escape
                        case 6: read(); break;//enter (read)
                        case 7: create(); break;//f1
                        case 8: update(); break; //f2
                        case 9: delete(); break;
                        case 10: break;
                    }
                } while (i != 5);
            }

        }
        public class storekeeper : Icrud
        {
            menu menuadm;
            public bool stupid()
            {
                Console.SetCursorPosition(Console.WindowLeft / 2, Console.WindowTop / 2);
                Console.WriteLine("Хотитет ли вы сделать это? y/n");
                ConsoleKeyInfo cki;
                do
                {
                    cki = Console.ReadKey();
                } while ((cki.Key != ConsoleKey.Y) && (cki.Key != ConsoleKey.N));
                if (cki.Key != ConsoleKey.Y) { return true; } else { return false; }
            }

            public void create()
            {
                goods swat = new goods();
                menuadm.clearshow();
                Console.Write("Имя - "); swat.name = Console.ReadLine();
                Console.Write("Стоимость - "); swat.cost = 66;
                Console.Write("Количество - "); swat.quantity = 540;
            }

            public void delete()
            {
                if (stupid())
                {
                    menuadm.clearshow();
                    chpoks.RemoveAt(menuadm.lastpos);
                    menuadm.goodsstolist();
                }

                
            }

            public void find()
            {
                throw new NotImplementedException();
            }

            public void read()
            {
                menuadm.clearshow();
                menuadm.goodstolist(chpoks[menuadm.lastpos]);
                menuadm.show();

            }

            public void update()
            {
                throw new NotImplementedException();
            }
            public storekeeper()
            {
                
                Console.Clear();
                Console.WriteLine(curentuser.login);
                menuadm = new menu();
                int i;
                menuadm.goodsstolist();
                do
                {
                    i = menuadm.main();
                    switch (i)
                    {
                        case 5: break;//escape
                        case 6: read(); break;//enter (read)
                        case 7: create(); break;//f1
                        case 8: update(); break; //f2
                        case 9: delete(); break;
                        case 10: break;
                    }
                } while (i != 5);
            }

        }
        public class bookkeeper : Icrud
        {
            public void create()
            {
                throw new NotImplementedException();
            }

            public void delete()
            {
                throw new NotImplementedException();
            }

            public void find()
            {
                throw new NotImplementedException();
            }

            public void read()
            {
                throw new NotImplementedException();
            }

            public void update()
            {
                throw new NotImplementedException();
            }
        }
        public class login
        {
            string inputpass()
            {
                void backstar()
                {
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    Console.Write("*");
                }
                string esp = "";
                ConsoleKeyInfo cki;
                do
                {
                    cki = Console.ReadKey();
                    esp = esp + cki.KeyChar;
                    if (cki.Key != ConsoleKey.Enter)
                    {
                        backstar();
                    }

                } while ((cki.Key != ConsoleKey.Escape) && (cki.Key != ConsoleKey.Enter));

                if (cki.Key != ConsoleKey.Escape) { return esp; } else { return ""; }
            }

            public login()
            {
                user tempuser = new user();
                string tmp;
                tempuser.login = "";
                tempuser.password = "2";
                do
                {
                    Console.WriteLine("Введите логин для авторизации");
                    string log = Console.ReadLine();
                    foreach (user us in split)
                    {
                        if (us.login == log) { tempuser = us; break; }
                    }
                    if (tempuser.login == "") { Console.Clear(); Console.WriteLine("Ошибка (неверный логин)"); }
                } while (tempuser.login == "");
                do
                {
                    Console.WriteLine("Введите пароь для авторизации");
                    tmp = inputpass();
                } while (tempuser.password == tmp);
                curentuser = tempuser;
            }

        }
        public class menu
        {
            public int startcol = 10, startrow = 5;
            public int newpos, lastpos;
            string[] coun = new string[255];
            string[] couninfo = new string[255];
            private int arrcont = 0;
            public void show()
            {
                Console.SetCursorPosition(startcol - 3, startrow - 3);
                for (int i = 0; i < arrcont; i++)
                {
                    Console.SetCursorPosition(startcol, startrow + i);
                    Console.WriteLine(coun[i]);

                    Console.SetCursorPosition(startcol + 50, startrow + i);
                    Console.WriteLine(couninfo[i]);
                }
            }
            public void clearshow()
            {
                Console.SetCursorPosition(startcol - 3, startrow - 3);
                Console.WriteLine("                                                    ");

                for (int i = 0; i < arrcont; i++)
                {
                    Console.SetCursorPosition(startcol + 50, startrow + i);
                    Console.WriteLine("                                                                  ");
                }
            }

            private void showpos()
            {
                Console.SetCursorPosition(startcol - 3, startrow + lastpos);
                Console.Write(' ');

                Console.SetCursorPosition(startcol - 3, startrow + newpos);
                Console.Write('\u0010');

            }
            private int keyinfo()
            {
                ConsoleKeyInfo cki;
                Console.TreatControlCAsInput = true;
                int i = 0;
                do
                {
                    cki = Console.ReadKey();
                    switch (cki.Key)
                    {
                        case ConsoleKey.UpArrow: i = 1; break;
                        case ConsoleKey.DownArrow: i = 2; break;
                        case ConsoleKey.LeftArrow: i = 3; break;
                        case ConsoleKey.RightArrow: i = 4; break;
                        case ConsoleKey.Escape: i = 5; break;
                        case ConsoleKey.Enter: i = 6; break;
                        case ConsoleKey.F1: i = 7; break;
                        case ConsoleKey.F2: i = 8; break;
                        case ConsoleKey.F10: i = 9; break;
                        case ConsoleKey.S: i = 10; break;
                    }
                } while (i == 0);
                return i;
            }
            public int main()
            {
                
                int i;
                show();
                showpos();
                do
                {
                    i = keyinfo();
                    
                    switch (i)
                    {
                        case 1: newpos--; break;
                        case 2: newpos++; break;
                            
                    }
                    if (newpos > arrcont - 1) { newpos = 0; }
                    if (newpos < 0) { newpos = arrcont - 1; }
                    showpos();


                } while (i <= 4);
                return i;

            }
            public void userstolist()
            {
                arrcont = split.Count;
                for (int i = 0; i < arrcont; i++)
                { coun[i] = split[i].login; }
            }
            public void usertolist(user monk)
            {
                arrcont = 2;
                coun[0] = monk.id.ToString();
                coun[1] = monk.login;
                coun[2] = monk.password;
                
            }
            public void piplstolist()
            {
                arrcont = urod.Count;
                for (int i = 0; i < arrcont; i++)
                { coun[i] = urod[i].famelename + " " + urod[i].name; }
            }
            public void pipltolist(people monk)
            {
                arrcont = 4;
                coun[0] = monk.id.ToString();
                coun[1] = monk.famelename;
                coun[2] = monk.name;
                coun[3] = monk.numberpassport;
                coun[4] = monk.salary.ToString();
                
            }
            public void goodsstolist()
            {
                arrcont = chpoks.Count;
                for (int i = 0; i < arrcont; i++)
                { coun[i] = chpoks[i].name; }
            }
            public void goodstolist(goods monk)
            {
                arrcont = 4;
                coun[0] = monk.id.ToString();
                coun[1] = monk.name;
                coun[2] = monk.cost.ToString();
                coun[3] = monk.quantity.ToString();
            }

        }


        public static void shop()
        {
            user oppa = new user();
            oppa.id = 1;
            oppa.login = "Админ";
            oppa.password = "123456789";
            oppa.roule = roule.Админ;

            split.Add(oppa);

            oppa.id = 2;
            oppa.login = "Кассир";
            oppa.password = "123456789";
            oppa.roule = roule.Кассир;

            split.Add(oppa);

            oppa.id = 3;
            oppa.login = "Менеджерперсонала";
            oppa.password = "123456789";
            oppa.roule = roule.Менеджерперсонала;

            split.Add(oppa);

            oppa.id = 4;
            oppa.login = "Кладовщик";
            oppa.password = "123456789";
            oppa.roule = roule.Кладовщик;

            split.Add(oppa);

            oppa.id = 5;
            oppa.login = "Бухгалтер";
            oppa.password = "123456789";
            oppa.roule = roule.Бухгалтер;

            split.Add(oppa);

            people gul = new people();
            gul.fathername = "Сеченов";
            gul.name = "Сергей";
            gul.fathername = "Семенович";
            gul.numberpassport = "8 910 483 50 96";
            gul.salary = 45000;
            urod.Add(gul);

            goods pivo = new goods();
            pivo.name = "Оливки";
            pivo.cost = 10;
            pivo.quantity = 1;
            chpoks.Add(pivo);
            pivo.name = "Спагетти";
            pivo.cost = 699;
            pivo.quantity = 1;
            chpoks.Add(pivo);
            pivo.name = "Чипсы";
            pivo.cost = 899;
            pivo.quantity = 69;
            chpoks.Add(pivo);
            pivo.name = "Огурцы";
            pivo.cost = 6;
            pivo.quantity = 540;
            chpoks.Add(pivo);

            login jedkei = new();
            if (curentuser.roule == roule.Админ) { admin bib = new admin(); }
            if (curentuser.roule == roule.Менеджерперсонала) { personnel add = new personnel(); }
            if (curentuser.roule == roule.Кладовщик) { storekeeper greg = new storekeeper(); }

        }

        static void Main(string[] args)
        {
            shop();
        }
    }
}
