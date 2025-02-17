/*
 * PagarmeCoreApi.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using PagarmeCoreApi.PCL.Controllers;
using PagarmeCoreApi.PCL.Http.Client;
using PagarmeCoreApi.PCL.Utilities;

namespace PagarmeCoreApi.PCL
{
    public partial class PagarmeCoreApiClient: IPagarmeCoreApiClient
    {

        /// <summary>
        /// Singleton access to Plans controller
        /// </summary>
        public IPlansController Plans
        {
            get
            {
                return PlansController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Subscriptions controller
        /// </summary>
        public ISubscriptionsController Subscriptions
        {
            get
            {
                return SubscriptionsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Orders controller
        /// </summary>
        public IOrdersController Orders
        {
            get
            {
                return OrdersController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Invoices controller
        /// </summary>
        public IInvoicesController Invoices
        {
            get
            {
                return InvoicesController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Customers controller
        /// </summary>
        public ICustomersController Customers
        {
            get
            {
                return CustomersController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Charges controller
        /// </summary>
        public IChargesController Charges
        {
            get
            {
                return ChargesController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Transfers controller
        /// </summary>
        public ITransfersController Transfers
        {
            get
            {
                return TransfersController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Recipients controller
        /// </summary>
        public IRecipientsController Recipients
        {
            get
            {
                return RecipientsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Tokens controller
        /// </summary>
        public ITokensController Tokens
        {
            get
            {
                return TokensController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Transactions controller
        /// </summary>
        public ITransactionsController Transactions
        {
            get
            {
                return TransactionsController.Instance;
            }
        }
        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public PagarmeCoreApiClient() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public PagarmeCoreApiClient(string basicAuthUserName, string basicAuthPassword)
        {
            Configuration.BasicAuthUserName = basicAuthUserName;
            Configuration.BasicAuthPassword = basicAuthPassword;
        }
        #endregion
    }
}