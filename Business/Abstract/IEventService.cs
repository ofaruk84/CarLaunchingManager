﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEventService
    {
        IDataResult<List<Event>> GetAll();
        IDataResult<Event> GetByEventId(int id);
        IDataResult<List<Event>> GetByCarId(int id);
        IDataResult<List<Event>> GetByCountryId(int id);
        IDataResult<List<Event>> GetByDestinationId(int id);
        IDataResult<List<EventDetailDto>> GetEventDto(int id);
        IDataResult<List<EventDetailDto>> GetEventsDtos();
        IResult Add(Event launch);
        IResult Delete(Event launch);
        IResult Update(Event launch);
    }
}