using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ShoopingCart
{
    public partial class Form1 : Form
    {
        private ImageList productImageList = new ImageList();

        public Form1()
        {
            InitializeComponent();

            // Set ImageList properties
            productImageList.ImageSize = new Size(100, 100);
            listViewProducts.LargeImageList = productImageList;
            listViewProducts.View = View.Details; // Set the view to Details
            listViewProducts.OwnerDraw = true; // Enable custom drawing
            listViewProducts.FullRowSelect = true; // Allow selecting full row

            // Set up columns for product info
            listViewProducts.Columns.Add("Product", 150);
            listViewProducts.Columns.Add("Description", 300);
            listViewProducts.Columns.Add("Price", 100);

            listViewProducts.DrawItem += ListViewProducts_DrawItem; // Handle custom drawing for items
            listViewProducts.DrawSubItem += ListViewProducts_DrawSubItem; // Handle sub-item drawing (like description and price)
            listViewProducts.DrawColumnHeader += ListViewProducts_DrawColumnHeader; // Handle drawing of column headers


        }

        private List<(string productName, string imageUrl, string description, decimal price)> mobiles = new List<(string, string, string, decimal)>
        {
            ("OnePlus", "Images/Azure.png", "OnePlus makes premium smartphones, headphones, and backpacks.", 32999),
            ("Xiaomi", "Images/NET.png", "Xiaomi makes premium smartphones and other consumer electronics.", 24000),
            ("Nokia", "Images/SQL.png", "Nokia is known for durable and reliable phones.", 16000),
        };

        private void DisplayProducts(List<(string productName, string imageUrl, string description, decimal price)> products)
        {
            listViewProducts.Items.Clear();
            productImageList.Images.Clear();

            foreach (var product in products)
            {
                try
                {
                    if (!string.IsNullOrEmpty(product.imageUrl) && File.Exists(product.imageUrl))
                    {
                        Image productImage = Image.FromFile(product.imageUrl);
                        productImageList.Images.Add(productImage); // Add image to ImageList
                    }

                    // Create a new ListViewItem with product name and details
                    var item = new ListViewItem(product.productName)
                    {
                        Tag = product.imageUrl // Store image path in the Tag for later use
                    };
                    item.SubItems.Add(product.description);
                    item.SubItems.Add($"?{product.price}");

                    listViewProducts.Items.Add(item); // Add item to ListView
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading image for {product.productName}: {ex.Message}");
                }
            }
        }

        // Draw column headers
        private void ListViewProducts_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true; // Use default drawing for headers
        }

        // Draw sub-items (description and price)
        private void ListViewProducts_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true; // Use default drawing for sub-items
        }

        // Draw each product item with image and text
        private void ListViewProducts_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawBackground(); // Draw the background

            // Draw image if it exists
            if (e.Item.Tag != null)
            {
                var imagePath = e.Item.Tag.ToString();
                if (File.Exists(imagePath))
                {
                    Image img = Image.FromFile(imagePath);
                    e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y, 100, 100); // Draw the image to the left
                }
            }

            // Draw product name
            e.Graphics.DrawString(e.Item.Text, e.Item.Font, Brushes.Black, e.Bounds.X + 110, e.Bounds.Y);

            // Use custom drawing for background focus
            if ((e.State & ListViewItemStates.Selected) != 0)
            {
                e.Graphics.FillRectangle(Brushes.LightBlue, e.Bounds); // Highlight the item when selected
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayProducts(mobiles);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}