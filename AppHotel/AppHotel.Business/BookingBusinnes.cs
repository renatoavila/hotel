using AppHotel.Domain.Entity;
using AppHotel.Repository;
using AppHotel.Repository.Base;
using AppHotel.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel.Business
{
    public class BookingBusinnes : IBookingBusinness
    {
        IBookingRepository _bookingRepository;

        public BookingBusinnes(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
           
        }

        public void Add()
        {
            //_bookingRepository.Obter2Quartos();
        }
    }
}
