﻿using OFood.Domain.Commons;

namespace OFood.Domain.Entities;

public class Cart : Entity<long>
{
    public int CartCount { get; set; }

    public string CartIdString { get; set;}
}