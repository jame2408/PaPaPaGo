﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PapapaGo.Models.Book
{
    public class Amount
    {
        public int cents { get; set; }
        public string currency { get; set; }
    }

    public class BookResponse : BaseResponse
    {
        public ChargingPrice charging_price { get; set; }
        public string created_at { get; set; }
        public DateTime departure { get; set; }
        public From from { get; set; }
        public string id { get; set; }
        public List<Passenger> passengers { get; set; }
        public PaymentPrice payment_price { get; set; }
        public Railway railway { get; set; }
        public RebateAmount rebate_amount { get; set; }
        public List<Record> records { get; set; }
        public RtpPrice rtp_price { get; set; }
        public TicketPrice ticket_price { get; set; }
        public List<Ticket> tickets { get; set; }
        public To to { get; set; }
    }

    public class ChargingPrice
    {
        public int cents { get; set; }
        public string currency { get; set; }
    }

    public class From
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Passenger
    {
        public string birthdate { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string gender { get; set; }
        public string id { get; set; }
        public string last_name { get; set; }
        public string phone { get; set; }
    }

    public class PaymentPrice
    {
        public int cents { get; set; }
        public string currency { get; set; }
    }

    public class Price
    {
        public int cents { get; set; }
        public string currency { get; set; }
    }

    public class Railway
    {
        public string code { get; set; }
    }

    public class RebateAmount
    {
        public int cents { get; set; }
        public string currency { get; set; }
    }

    public class Record
    {
        public Amount amount { get; set; }
        public string category { get; set; }
        public string id { get; set; }
        public string target { get; set; }
        public string type { get; set; }
    }

    public class RtpPrice
    {
        public int cents { get; set; }
        public string currency { get; set; }
    }

    public class Ticket
    {
        public From from { get; set; }
        public string id { get; set; }
        public Price price { get; set; }
        public To to { get; set; }
    }

    public class TicketPrice
    {
        public int cents { get; set; }
        public string currency { get; set; }
    }

    public class To
    {
        public string code { get; set; }
        public string name { get; set; }
    }
}