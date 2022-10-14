double distance = 10000;
int count = 0;
int v1 = 1;
int v2 = 2;
int vdog = 5;
int friend = 2;
double time = 0;
while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (v1 + vdog);
        friend = 2;
    }
    else
    {
        time = distance / (v2 + vdog);
        friend = 1;
    }
    distance = distance - (v1 + v2) * time;
    count++;
}
Console.WriteLine( "Собака пробежит " + count + " раз" );
