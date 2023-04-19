int speedFirstFriend = 1,
    speedSecondFriend = 3,
    speedDog = 5;

int distance = 10000,
    friend = 2,
    count = 0,
    time = 0;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (speedFirstFriend + speedDog);
        friend = 2;
    }
    else
    {
        time = distance / (speedSecondFriend + speedDog);
        friend = 1;
    }
    distance = distance - (speedFirstFriend + speedSecondFriend) * time;
    count++;
}    

Console.WriteLine(distance);