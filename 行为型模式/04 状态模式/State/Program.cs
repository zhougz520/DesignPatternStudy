using State;

class Program
{
    static void Main(string[] args)
    {
        Work proj = new Work();
        proj.Hour = 9;
        proj.WriteProgram();
        proj.Hour = 10;
        proj.WriteProgram();
        proj.Hour = 12;
        proj.WriteProgram();
        proj.Hour = 13;
        proj.WriteProgram();
        proj.Hour = 14;
        proj.WriteProgram();
        proj.Hour = 17;

        proj.TaskFinished = false;

        proj.WriteProgram();
        proj.Hour = 19;
        proj.WriteProgram();
        proj.Hour = 22;
        proj.WriteProgram();
    }
}