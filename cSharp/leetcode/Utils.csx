public void RunTests(IEnumerable<Action> actions, bool continueIfFails = false)
{
    var isAllPassed = true;
    foreach (var action in actions)
    {
        try
        {
            action();
            Console.WriteLine($"[✔] Test: {action.Method.Name} - PASSED");
        }
        catch (Exception ex)
        {
            isAllPassed = false;
            Console.WriteLine(ex);
            if (!continueIfFails)
            {
                return;
            }
            continue;
        }
    }
    if (isAllPassed)
    {
        Console.WriteLine("[✔] ALL TESTS PASSED");
    }
}
