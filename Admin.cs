﻿@model IEnumerable<YourNamespace.Models.Insuree>

<table>
    <thead>
        <tr>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Email</th>
            <th>Quote</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var insuree in Model)
{
            < tr >
                < td > @insuree.FirstName </ td >
                < td > @insuree.LastName </ td >
                < td > @insuree.Email </ td >
                < td > @insuree.Quote </ td >
            </ tr >
        }
    </ tbody >
</ table >

