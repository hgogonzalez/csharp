namespace find_the_index_of_the_first_occurrence_in_a_string;

class Program
{
    public int StrStr(string haystack, string needle) {
        if (needle == "")
            return 0;

        int index = haystack.IndexOf(needle);

        return index;
    }
    static void Main(string[] args)
    {
        Program solution = new Program();
        string haystack = "sadbutsad";
        string needle = "sad";
        int index = solution.StrStr(haystack, needle);
        Console.WriteLine("Output: " + index); 
    }
}
