/*
Реализовать метод проверки логина и пароля. 
На вход метода подается логин и пароль.
 На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
  Используя метод проверки логина и пароля, написать программу: 
  пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
  С помощью цикла do while ограничить ввод пароля тремя попытками.
*/

int tries = 3;
string login = "root", password = "GeekBrains";
string tryLogin, tryPassword;

do
{
    Console.WriteLine ($"Попыток ввода логина и пароля: {tries}");
    tryLogin = Console.ReadLine ();
    tryPassword = Console.ReadLine ();
    tries --;

if (login == tryLogin && password == tryPassword)
    Console.WriteLine ("Логин и пароль введен верно");

} while (login != tryLogin && password != tryPassword && tries >= 0); 