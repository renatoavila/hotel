using AppHotel.Domain.Entity;
using AppHotel.Repository;
using System;
using System.Collections.Generic;
using Xunit;

namespace ApcpHotel.Repository.Test
{
    public class Repository_Test
    {
        [Fact]
        public void Full()
        {
            // 1 - cadastro das categorias
            CategoryRepository categoryRepository = new CategoryRepository();

            Category categorySingle = new Category("Single", 230);
            categoryRepository.Create(categorySingle);
            
            Category categoryStandard = new Category("Standard", 310);
            categoryRepository.Create(categoryStandard);

            Category categoryLuxo = new Category("Luxo", 470);
            categoryRepository.Create(categoryLuxo);

            Assert.True(categoryRepository.Get().Count == 3);

            // 2 - cadastro do quarto

            RoomRepository roomRepository = new RoomRepository();

            Room roomSingle01 = new Room("01", categorySingle);
            roomRepository.Create(roomSingle01);

            Room roomSingle02 = new Room("02", categorySingle);
            roomRepository.Create(roomSingle02);

            Room roomStandard03 = new Room("03", categoryStandard);
            roomRepository.Create(roomStandard03);

            Room roomStandard04 = new Room("04", categoryStandard);
            roomRepository.Create(roomStandard04);

            Room roomLuxo05 = new Room("05", categoryLuxo);
            roomRepository.Create(roomLuxo05);

            Room roomLuxo06 = new Room("05", categoryLuxo);
            roomRepository.Create(roomLuxo05);

            Assert.True(roomRepository.Get().Count == 6);

            // 3 - cadstro do hospede
            HotelGuestRepository hotelGuestRepositoryRepository = new HotelGuestRepository();

            HotelGuest hotelGuest = new HotelGuest("João de Barro","joaobarro@gmail.com", "000.111.222-33","(19) 99999-9999");
            hotelGuestRepositoryRepository.Create(hotelGuest);

            Assert.True(hotelGuestRepositoryRepository.Get().Count == 1);

            // 4 - cadastro da reserva
            BookingRepository bookingRepository = new BookingRepository();

            Booking booking = new Booking(hotelGuest, DateTime.Now.AddDays(1), DateTime.Now.AddDays(2), roomSingle01);
            bookingRepository.Create(booking);

            Assert.True(bookingRepository.Get().Count == 1);

        }
    }
}
