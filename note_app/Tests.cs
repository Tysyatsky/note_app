﻿


static class Tests
{
    public static void Test1()
    {
        Buffer myBuf = new Buffer(2);

        myBuf.CreateNote();
        myBuf.CreateNote();
        myBuf.CreateNote();
        
        myBuf.ListAllNames();
        
    }
    public static void Test2()
    {
        Buffer myBuf = new Buffer(1);
        Menu mainMenu = new Menu();
        mainMenu.Start();
        if (myBuf == null) { Console.WriteLine("Error on creation"); }
        else { Console.WriteLine("All good"); }
        mainMenu.NewNote();
        myBuf.ListAllNames();
    }
}