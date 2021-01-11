using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookMyTickets.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net.Mail;
using System.Net;

namespace BookMyTickets.Controllers
{
    public class BookingsController : Controller
    {
        private readonly AppDbContext _context;
        int showId;
        public BookingsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult payment(IFormCollection fc)
        {
            int seat1 = Int32.Parse(fc["seat"]);
            showId = Int32.Parse(fc["ShowId"]);
            double seatprice= Double.Parse(fc["price"]);
            ViewBag.seat = seat1;
            ViewBag.ShowId = showId;
            ViewBag.price = seatprice*100;
            return View();
        }
            public IActionResult ConfirmBookingPhase4(IFormCollection fc)
        {
            //ViewBag.TotalTickets = fc["TotalTickets"];
            //int totalTickets = Int32.Parse(fc["TotalTickets"]);
            int seat1 = Int32.Parse(fc["seat"]);
         
            int showId = Int32.Parse(fc["ShowId"]);
           
            Booking book = new Booking();
            
                var bookingSeat = _context.Bookings.FirstOrDefault(x => x.ShowId == showId && x.UserName == HttpContext.Session.GetString("UserName") && (x.Seat == seat1));
                if (bookingSeat != null)
                {
                    return RedirectToAction("BookingPhase1", "Shows");
                }
                else
                {
                    book.TotalTickets = 1;
                    book.Seat = seat1;
              

                    book.ShowId = showId;
                    var Show = _context.Shows.FirstOrDefault(x => x.ShowId == showId);
                    var user = _context.Users.FirstOrDefault(x => x.UserName == HttpContext.Session.GetString("UserName"));
                    var movie = _context.Movies.FirstOrDefault(x => x.MovieName == Show.MovieName);
                    book.UserName = HttpContext.Session.GetString("UserName");
                    book.MovieName = Show.MovieName;
                    book.ScreenNo = Show.ScreenNo;
                    book.TheaterName = Show.TheaterName;
                    book.UserId = user.UserId;
                    book.City = Show.City;
                    book.Date = Show.Date;
                if (book.Seat <= 20)
                {
                    string bill = (Show.GoldenPrice).ToString();
                    int bill2 = Int32.Parse(bill);
                    double Cost = (bill2);
                    book.TotalCost = Cost;
                }
                else
                {
                    string bill = (Show.Price).ToString();
                    int bill2 = Int32.Parse(bill);
                    double Cost = (bill2);
                    book.TotalCost = Cost;
                }
                string qr = book.MovieName + ";" + book.ShowId + ";" + book.Seat;
                using (MemoryStream ms = new MemoryStream())
                {
                    QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
                    QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(qr, QRCodeGenerator.ECCLevel.Q);
                    QRCode qRCode = new QRCode(qRCodeData);
                    using (Bitmap bitmap=qRCode.GetGraphic(20))
                    {
                        bitmap.Save(ms, ImageFormat.Png);
                        ViewBag.QRCode = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
                        try
                        {
                            using (MailMessage mail = new MailMessage())
                            {
                                //mail.From = new MailAddress("aspnetproject43@gmail.com");
                                //mail.To.Add("201710643@ua.edu.lb");
                                //mail.Subject = "Qrcode";
                                ////mail.Body = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
                                //mail.Body = "sakasdklasdklasdkl";
                                //using (SmtpClient smtp = new SmtpClient("smtp.gmail.com",587))
                                //{
                                //    smtp.Credentials = new System.Net.NetworkCredential("aspnetproject43@gmail.com", "201710907");
                                //    smtp.EnableSsl = true;
                                //    smtp.Send(mail);
                                //    ViewBag.MovieName = "EmailSent";
                                //}
                               // SmtpClient smtpClient = new SmtpClient("relay-hosting.secureserver.net", 25);

                               // smtpClient.Credentials = new System.Net.NetworkCredential("aspnetproject43@gmail.com", "201710907");
                               // smtpClient.UseDefaultCredentials = true; 
                               // smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                               // smtpClient.EnableSsl = true;
                                

                               
                               // mail.From = new MailAddress("aspnetproject43@gmail.com", "MyWeb Site");
                               // mail.To.Add(new MailAddress("201710907@ua.edu.lb"));
                               //mail.CC.Add(new MailAddress("MyEmailID@gmail.com"));

                               // smtpClient.Send(mail);

                               
                                    MailMessage msg = new MailMessage();
                                    mail.From = new MailAddress("aspnetproject43@gmail.com");
                                    mail.To.Add("201710643@ua.edu.lb");
                                    mail.Subject = "Qrcode";
                                    mail.Body = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
                                    msg.From = new MailAddress("aspnetproject43@gmail.com");
                                    msg.To.Add("Your payment is done");
                                    msg.Body = "Testing the automatic mail";
                                    msg.IsBodyHtml = true;
                                    msg.Subject = "Movie Data";
                                    SmtpClient smt = new SmtpClient("smtp.gmail.com");
                                    smt.Port = 587;
                                    smt.Credentials = new NetworkCredential("aspnetproject43@gmail.com", "MyWeb Site");
                                    smt.EnableSsl = true;
                                    smt.Send(msg);
                                    string script = "<script>alert('Mail Sent Successfully');self.close();</script>";
                            }
                        }
                        catch(Exception ex)
                        {
                            ViewBag.MovieName = Show.MovieName;
                        }
                    }
                }
                
                ViewBag.Url = movie.PosterUrl;
                   // ViewBag.MovieName = movie.MovieName;
                    ViewBag.Language = movie.Language;
                    ViewBag.Genre = movie.Genre;
                    ViewBag.Director = movie.Director;
                    ViewBag.Duretion = movie.Duretion;
                    ViewBag.ReleseDate = movie.ReleaseDate;
                    ViewBag.StartTime = Show.StartTime;
                    ViewBag.Price = Show.Price;
                    _context.Add(book);
                    _context.SaveChanges();
                    return View(book);
                }

            
            
        }

    public IActionResult seatSelectionBookingPhase3(IFormCollection fc)
    {
        ViewBag.ShowId = fc["ShowId"];
        showId = Int32.Parse(fc["ShowId"]);
        var Show = _context.Shows.FirstOrDefault(x => x.ShowId == showId);
        var Movie = _context.Movies.FirstOrDefault(x => x.MovieName == Show.MovieName);
        ViewBag.MovieName = Movie.MovieName;
        ViewBag.Url = Movie.PosterUrl;
        ViewBag.Language = Movie.Language;
        ViewBag.Genre = Movie.Genre;
        ViewBag.Director = Movie.Director;
        ViewBag.Duretion = Movie.Duretion;
        ViewBag.ReleaseDate = Movie.ReleaseDate;
        ViewBag.TheaterName = Show.TheaterName;
        ViewBag.StartTime = Show.StartTime;
        ViewBag.ScreenNo = Show.ScreenNo;
        ViewBag.Date = Show.Date;
        ViewBag.Price = Show.Price;
        ViewBag.GoldenPrice = Show.GoldenPrice;
            var AllseatsRead = _context.Bookings.Where(b => b.ShowId == Show.ShowId).ToList();
            var AllSeats = new List<int>();

            foreach (var s in AllseatsRead)
            {
                AllSeats.Add(s.Seat);
            }
            ViewBag.Allseats = AllSeats;
            return View();
        
        }

        public IActionResult SoldTickets()
        {
            var sold = _context.Bookings.Where(x => x.TheaterName == HttpContext.Session.GetString("TheaterName")).ToList();
            return View(sold);
        }

        public IActionResult BookedTicketsOfUser()
        {
            var booking = _context.Bookings.Where(x => x.UserName == HttpContext.Session.GetString("UserName")).ToList();
            var codes = new List<string>();
            foreach (var book in booking)
            {
                string qr = book.MovieName + ";" + book.ShowId + ";" + book.Seat;
                using (MemoryStream ms = new MemoryStream())
                {
                    QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
                    QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(qr, QRCodeGenerator.ECCLevel.Q);
                    QRCode qRCode = new QRCode(qRCodeData);
                    using (Bitmap bitmap = qRCode.GetGraphic(20))
                    {
                        bitmap.Save(ms, ImageFormat.Png);
                                codes.Add("data:image/png;base64," + Convert.ToBase64String(ms.ToArray()));
                    }
                }
            }
            ViewBag.codes = codes;
            return View(booking);
        }
        // GET: Bookings
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Bookings.Include(b => b.Show).Include(b => b.User);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Bookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings
                .Include(b => b.Show)
                .Include(b => b.User)
                .FirstOrDefaultAsync(m => m.BookingId == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // GET: Bookings/Create
        public IActionResult Create()
        {
            ViewData["ShowId"] = new SelectList(_context.Shows, "ShowId", "ShowId");
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email");
            return View();
        }

        // POST: Bookings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookingId,UserId,ShowId,TotalTickets,SeatNo1,SeatNo2,SeatNo3,TotalCost,Date,MovieName,TheaterName,UserName,City,ScreenNo")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ShowId"] = new SelectList(_context.Shows, "ShowId", "ShowId", booking.ShowId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email", booking.UserId);
            return View(booking);
        }

        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }
            ViewData["ShowId"] = new SelectList(_context.Shows, "ShowId", "ShowId", booking.ShowId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email", booking.UserId);
            return View(booking);
        }

        // POST: Bookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookingId,UserId,ShowId,TotalTickets,SeatNo1,SeatNo2,SeatNo3,TotalCost,Date,MovieName,TheaterName,UserName,City,ScreenNo")] Booking booking)
        {
            if (id != booking.BookingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(booking.BookingId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ShowId"] = new SelectList(_context.Shows, "ShowId", "ShowId", booking.ShowId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email", booking.UserId);
            return View(booking);
        }

        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings
                .Include(b => b.Show)
                .Include(b => b.User)
                .FirstOrDefaultAsync(m => m.BookingId == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(int id)
        {
            return _context.Bookings.Any(e => e.BookingId == id);
        }
    }
}
