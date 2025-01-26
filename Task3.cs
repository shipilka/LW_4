int[,] distances = {
{0, 10, 15, 20 },
{10, 0, 35, 25 },
{15, 35, 0, 30 },
{20, 25, 30, 0 }
};

int n = distances.GetLength(0);
int[] visited = new int[n];
int[] path = new int[n];
int currentCity = 0;
visited[currentCity] = 1;
path[0] = currentCity;

for (int step = 1; step < n; step++)
{
    int nearestCity = -1;
    int minDistance = int.MaxValue;

    for (int i = 0; i < n; i++)
    {
        if (visited[i] == 0 && distances[currentCity, i] < minDistance)
        {
            minDistance = distances[currentCity, i];
            nearestCity = i;
        }
    }
    visited[nearestCity] = 1;
    path[step] = nearestCity;
    currentCity = nearestCity;
}

Console.WriteLine("Приближенный маршрут: ");
for (int i = 0;i < n;i++)
{
    Console.Write(path[i]+(i < n-1 ? "->" : ""));
}