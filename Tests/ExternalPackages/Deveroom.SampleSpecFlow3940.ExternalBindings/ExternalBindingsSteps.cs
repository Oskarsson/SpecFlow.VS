﻿using TechTalk.SpecFlow;

namespace Deveroom.SampleSpecFlow3940.ExternalBindingsX;

[Binding]
public class ExternalBindingsSteps
{
    [Then("there should be a step from an external assembly")]
    public void ThenThereShouldBeAStepFromAnExternalAssembly()
    {
        Console.WriteLine("Hello from external assembly!");
    }
}
