﻿namespace StyleCopExample.Domain.Entities;

public class Order
{
    public Guid Id { get; set; }

    public required string Name { get; set; }
}