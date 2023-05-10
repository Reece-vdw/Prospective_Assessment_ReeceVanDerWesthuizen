public static string Likes(List<string> names)
{
    int numberOfLikes = names.Count;

    if (numberOfLikes == 0)
    {
        return "no one likes this";
    }
    else if (numberOfLikes == 1)
    {
        return $"{names[0]} likes this";
    }
    else if (numberOfLikes == 2)
    {
        return $"{names[0]} and {names[1]} like this";
    }
    else if (numberOfLikes == 3)
    {
        return $"{names[0]}, {names[1]} and {names[2]} like this";
    }
    else
    {
        return $"{string.Join(", ", names.Take(2))} and {numberOfLikes - 2} others like this";
    }
}
