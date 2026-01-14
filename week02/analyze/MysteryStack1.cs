public static class MysteryStack1 {
    public static string Run(string text) {
        var stack = new Stack<char>();
        foreach (var letter in text)
            stack.Push(letter);

        var result = "";
        while (stack.Count > 0)
            result += stack.Pop();

        return result;
    }
}

/*
Determine the output of the function if the input text is equal to the following:
1.-racecar
2.-stressed
3.-a nut for a jar of tuna

results:
1.- racecar
2.- desserts
3.- anut fo raj a rof tun a

*/