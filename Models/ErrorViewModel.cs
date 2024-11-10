public ActionResult Admin()
{
    var quotes = _context.Insurees.ToList();
    return View(quotes);
}
