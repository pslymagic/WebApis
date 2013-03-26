﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("PMDataContext", "FK_Product_Category", "Category", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(WebApis.Models.Category), "Products", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(WebApis.Models.Product), true)]
[assembly: EdmRelationshipAttribute("PMDataContext", "FK_Cart_Product", "Product", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(WebApis.Models.Product), "Cart", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(WebApis.Models.Cart), true)]

#endregion

namespace WebApis.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class PMEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new PMEntities object using the connection string found in the 'PMEntities' section of the application configuration file.
        /// </summary>
        public PMEntities() : base("name=PMEntities", "PMEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PMEntities object.
        /// </summary>
        public PMEntities(string connectionString) : base(connectionString, "PMEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PMEntities object.
        /// </summary>
        public PMEntities(EntityConnection connection) : base(connection, "PMEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Category> Categories
        {
            get
            {
                if ((_Categories == null))
                {
                    _Categories = base.CreateObjectSet<Category>("Categories");
                }
                return _Categories;
            }
        }
        private ObjectSet<Category> _Categories;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Product> Products
        {
            get
            {
                if ((_Products == null))
                {
                    _Products = base.CreateObjectSet<Product>("Products");
                }
                return _Products;
            }
        }
        private ObjectSet<Product> _Products;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Cart> Carts
        {
            get
            {
                if ((_Carts == null))
                {
                    _Carts = base.CreateObjectSet<Cart>("Carts");
                }
                return _Carts;
            }
        }
        private ObjectSet<Cart> _Carts;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Categories EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCategories(Category category)
        {
            base.AddObject("Categories", category);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Products EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToProducts(Product product)
        {
            base.AddObject("Products", product);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Carts EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCarts(Cart cart)
        {
            base.AddObject("Carts", cart);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PMDataContext", Name="Cart")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Cart : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Cart object.
        /// </summary>
        /// <param name="cartId">Initial value of the CartId property.</param>
        /// <param name="uniqueIdentifier">Initial value of the UniqueIdentifier property.</param>
        /// <param name="productId">Initial value of the ProductId property.</param>
        public static Cart CreateCart(global::System.Int32 cartId, global::System.Guid uniqueIdentifier, global::System.Int32 productId)
        {
            Cart cart = new Cart();
            cart.CartId = cartId;
            cart.UniqueIdentifier = uniqueIdentifier;
            cart.ProductId = productId;
            return cart;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CartId
        {
            get
            {
                return _CartId;
            }
            set
            {
                if (_CartId != value)
                {
                    OnCartIdChanging(value);
                    ReportPropertyChanging("CartId");
                    _CartId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CartId");
                    OnCartIdChanged();
                }
            }
        }
        private global::System.Int32 _CartId;
        partial void OnCartIdChanging(global::System.Int32 value);
        partial void OnCartIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid UniqueIdentifier
        {
            get
            {
                return _UniqueIdentifier;
            }
            set
            {
                OnUniqueIdentifierChanging(value);
                ReportPropertyChanging("UniqueIdentifier");
                _UniqueIdentifier = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UniqueIdentifier");
                OnUniqueIdentifierChanged();
            }
        }
        private global::System.Guid _UniqueIdentifier;
        partial void OnUniqueIdentifierChanging(global::System.Guid value);
        partial void OnUniqueIdentifierChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ProductId
        {
            get
            {
                return _ProductId;
            }
            set
            {
                OnProductIdChanging(value);
                ReportPropertyChanging("ProductId");
                _ProductId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ProductId");
                OnProductIdChanged();
            }
        }
        private global::System.Int32 _ProductId;
        partial void OnProductIdChanging(global::System.Int32 value);
        partial void OnProductIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Quantity
        {
            get
            {
                return _Quantity;
            }
            set
            {
                OnQuantityChanging(value);
                ReportPropertyChanging("Quantity");
                _Quantity = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Quantity");
                OnQuantityChanged();
            }
        }
        private Nullable<global::System.Int32> _Quantity;
        partial void OnQuantityChanging(Nullable<global::System.Int32> value);
        partial void OnQuantityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DateCreated
        {
            get
            {
                return _DateCreated;
            }
            set
            {
                OnDateCreatedChanging(value);
                ReportPropertyChanging("DateCreated");
                _DateCreated = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateCreated");
                OnDateCreatedChanged();
            }
        }
        private Nullable<global::System.DateTime> _DateCreated;
        partial void OnDateCreatedChanging(Nullable<global::System.DateTime> value);
        partial void OnDateCreatedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> OrderGenerated
        {
            get
            {
                return _OrderGenerated;
            }
            set
            {
                OnOrderGeneratedChanging(value);
                ReportPropertyChanging("OrderGenerated");
                _OrderGenerated = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("OrderGenerated");
                OnOrderGeneratedChanged();
            }
        }
        private Nullable<global::System.Boolean> _OrderGenerated;
        partial void OnOrderGeneratedChanging(Nullable<global::System.Boolean> value);
        partial void OnOrderGeneratedChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PMDataContext", "FK_Cart_Product", "Product")]
        public Product Product
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Product>("PMDataContext.FK_Cart_Product", "Product").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Product>("PMDataContext.FK_Cart_Product", "Product").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Product> ProductReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Product>("PMDataContext.FK_Cart_Product", "Product");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Product>("PMDataContext.FK_Cart_Product", "Product", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PMDataContext", Name="Category")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Category : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Category object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static Category CreateCategory(global::System.Int32 id)
        {
            Category category = new Category();
            category.Id = id;
            return category;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PMDataContext", "FK_Product_Category", "Products")]
        public EntityCollection<Product> Products
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Product>("PMDataContext.FK_Product_Category", "Products");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Product>("PMDataContext.FK_Product_Category", "Products", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PMDataContext", Name="Product")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Product : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Product object.
        /// </summary>
        /// <param name="productId">Initial value of the ProductId property.</param>
        public static Product CreateProduct(global::System.Int32 productId)
        {
            Product product = new Product();
            product.ProductId = productId;
            return product;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ProductId
        {
            get
            {
                return _ProductId;
            }
            set
            {
                if (_ProductId != value)
                {
                    OnProductIdChanging(value);
                    ReportPropertyChanging("ProductId");
                    _ProductId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ProductId");
                    OnProductIdChanged();
                }
            }
        }
        private global::System.Int32 _ProductId;
        partial void OnProductIdChanging(global::System.Int32 value);
        partial void OnProductIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> Price
        {
            get
            {
                return _Price;
            }
            set
            {
                OnPriceChanging(value);
                ReportPropertyChanging("Price");
                _Price = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Price");
                OnPriceChanged();
            }
        }
        private Nullable<global::System.Decimal> _Price;
        partial void OnPriceChanging(Nullable<global::System.Decimal> value);
        partial void OnPriceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Stock
        {
            get
            {
                return _Stock;
            }
            set
            {
                OnStockChanging(value);
                ReportPropertyChanging("Stock");
                _Stock = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Stock");
                OnStockChanged();
            }
        }
        private Nullable<global::System.Int32> _Stock;
        partial void OnStockChanging(Nullable<global::System.Int32> value);
        partial void OnStockChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Category
        {
            get
            {
                return _Category;
            }
            set
            {
                OnCategoryChanging(value);
                ReportPropertyChanging("Category");
                _Category = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Category");
                OnCategoryChanged();
            }
        }
        private Nullable<global::System.Int32> _Category;
        partial void OnCategoryChanging(Nullable<global::System.Int32> value);
        partial void OnCategoryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ImageUrl
        {
            get
            {
                return _ImageUrl;
            }
            set
            {
                OnImageUrlChanging(value);
                ReportPropertyChanging("ImageUrl");
                _ImageUrl = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ImageUrl");
                OnImageUrlChanged();
            }
        }
        private global::System.String _ImageUrl;
        partial void OnImageUrlChanging(global::System.String value);
        partial void OnImageUrlChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PMDataContext", "FK_Product_Category", "Category")]
        public Category Category1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Category>("PMDataContext.FK_Product_Category", "Category").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Category>("PMDataContext.FK_Product_Category", "Category").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Category> Category1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Category>("PMDataContext.FK_Product_Category", "Category");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Category>("PMDataContext.FK_Product_Category", "Category", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PMDataContext", "FK_Cart_Product", "Cart")]
        public EntityCollection<Cart> Carts
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Cart>("PMDataContext.FK_Cart_Product", "Cart");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Cart>("PMDataContext.FK_Cart_Product", "Cart", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
