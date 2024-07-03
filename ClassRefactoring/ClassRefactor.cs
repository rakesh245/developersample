using System;

namespace DeveloperSample.ClassRefactoring;

public enum SwallowType
{
    African, European
}

public enum SwallowLoad
{
    None, Coconut
}

public class SwallowFactory
{
    public Swallow GetSwallow(SwallowType swallowType) => new(swallowType);
}

public class Swallow
{
    public SwallowType Type { get; }
    public SwallowLoad Load { get; private set; }

    public Swallow(SwallowType swallowType)
    {
        Type = swallowType;
    }

    public void ApplyLoad(SwallowLoad load)
    {
        Load = load;
    }

    /// <summary>
    /// Basic refactoring
    /// </summary>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    //public double GetAirspeedVelocity()
    //{
    //    switch (Type)
    //    {
    //        case SwallowType.African:
    //            switch (Load)
    //            {
    //                case SwallowLoad.None:
    //                    return 22;
    //                case SwallowLoad.Coconut:
    //                    return 18;
    //            }

    //            break;
    //        case SwallowType.European:
    //            switch (Load)
    //            {
    //                case SwallowLoad.None:
    //                    return 20;
    //                case SwallowLoad.Coconut:
    //                    return 16;
    //            }

    //            break;
    //    }

    //    throw new InvalidOperationException();
    //}
    
    public double GetAirspeedVelocity()
    {
        return Type switch
        {
            SwallowType.African when Load == SwallowLoad.None => 22,
            SwallowType.African when Load == SwallowLoad.Coconut => 18,
            SwallowType.European when Load == SwallowLoad.None => 20,
            SwallowType.European when Load == SwallowLoad.Coconut => 16,
            _ => throw new InvalidOperationException()
        };
    }
}