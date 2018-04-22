//7.1 Card game, boring

//7.2 Imagine you have a call center with three levels of employees
//fresher, technical lead (TL), product manager (PM).
//Chains of responsibility
public interface ICallHandler()
{
    bool Handle();
}

public class Employee
{

}

public class Fresher: Employee, ICallHandler
{
    public bool Handle(){}
}

public class TechnicalLead: Employee, ICallHandler
{
    public bool Handle(){}
}

public class ProductManager: Employee, ICallHandler
{
    public bool Handle(){}
}

public class CallCenter
{
    private List<Fresher> _freshers;
    private TechnicalLead _tl;
    private ProductManager _pm;

    public CallCenter(List<Fresher> freshers, TechnicalLead tl, ProductManager pm){}

    public void HandCall()
    {
        foreach(var f in _freshers)
            if(canHanf.Handle())
                return;
        if(_tl.Handle()) return;
        _pm.Handle();
    }
}