public ActionResult CalculateQuote(Insuree insuree)
{
    double basePrice = 50.0;
    double totalPrice = basePrice;

    // Age logic
    if (insuree.Age <= 18)
    {
        totalPrice += 100;
    }
    else if (insuree.Age >= 19 && insuree.Age <= 25)
    {
        totalPrice += 50;
    }
    else if (insuree.Age >= 26)
    {
        totalPrice += 25;
    }

    // Car year logic
    if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
    {
        totalPrice += 25;
    }

    // Car Make logic
    if (insuree.CarMake == "Porsche")
    {
        totalPrice += 25;

        // Additional check for Porsche 911 Carrera
        if (insuree.CarModel == "911 Carrera")
        {
            totalPrice += 25; // Total of $50 for Porsche 911 Carrera
        }
    }

    // Speeding tickets logic
    totalPrice += insuree.SpeedingTickets * 10;

    // DUI logic
    if (insuree.HasDUI)
    {
        totalPrice *= 1.25; // 25% increase
    }

    // Full coverage logic
    if (insuree.HasFullCoverage)
    {
        totalPrice *= 1.50; // 50% increase
    }

    // Return the total calculated quote
    insuree.Quote = totalPrice;
    return View(insuree);
}
