namespace ULearn.Module_1_6;

public class OptimizeContactsTask
{
    public static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
    {
        var dictionary = new Dictionary<string, List<string>>();
        
        foreach (var contact in contacts) 
        {
            var name = contact.Substring(0, 2).Replace(":", "");
            if (!dictionary.ContainsKey(name))
                dictionary[name] = new List<string>();
            dictionary[name].Add(contact);
        }

        return dictionary;
    }
}