namespace V1_0_0;

using System.Net;

public class NexusRepositoryServerVarA
{
    
    public const string PASSWORD = "s3cr3t_and_c0nfi6ent1al";

    public int DoSomeMagicAndReturn0()
    {
        if (true)
        {
            
        }
        else
        {
            
        }
        // Do some magic
        return 0;
    }
    
    public string DoMoreMagicAndReturnA()
    {
        //Do more magic
        return "A";
    }

    public void SomeCodeSmell(string url)
    {
        WebRequest.Create(url);
    }
    
}