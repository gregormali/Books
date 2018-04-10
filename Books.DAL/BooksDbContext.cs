using Books.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.DAL
{
    /// <summary>
    /// Books db context.
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class BooksDbContext : DbContext
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BooksDbContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options) {

    
        }

        #endregion Contructors

        #region Properties

        /// <summary>
        /// Gets or sets the authors.
        /// </summary>
        /// <value>
        /// The authors.
        /// </value>
        public DbSet<Author> Authors { get; set; }
        /// <summary>
        /// Gets or sets the books.
        /// </summary>
        /// <value>
        /// The books.
        /// </value>
        public DbSet<Book> Books { get; set; }

        #endregion Properties

    }
}
