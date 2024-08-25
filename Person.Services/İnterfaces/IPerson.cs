using Person.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Person.Services.İnterfaces
{
    public interface IPerson
    {
        PersonModel.Return login(PersonModel.request personobj);
    }
}
