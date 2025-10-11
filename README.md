# Takeaway Titans

Takeaway Titans is a Blazor Server web app that lets guests order smoothies and salads for pickup while giving admins tools to manage incoming orders. Use this guide to understand the experience and run the app yourself.

---

## Quick Links
- Live site: https://takeaway-titans.onrender.com
- Stack: .NET 8, Blazor Server, Entity Framework Core, PostgreSQL, Blazor Bootstrap

---

## What You Can Do

### Guests
- Browse a photo-rich menu with prices and descriptions.
- Customize any item (quantity, notes) and keep selections in a persistent cart.
- Check out with contact info and receive a unique four-digit pickup code.
- Track order progress in real time with email plus order code.

### Admins
- Sign in with seeded credentials and stay authenticated via secure cookie.
- View orders grouped by lifecycle stage (Received → Preparing → Ready → Completed → Canceled).
- Expand an order card to see customer details, item breakdowns, timestamps, and status history.
- Advance orders through the workflow with a single click per stage.

---

## Navigating the App

### Landing & Home
- `"/"` presents the hero call-to-action. Buttons jump directly to Menu, Order, or Track.
- `"/home"` summarizes the three core actions and highlights the 20-minute pickup lead time.

### Menu (`/menu`)
1. Browse cards for salads and smoothies; select **Customize** on any item.
2. Adjust quantity, add special instructions, then use **Add to Cart**.
3. The floating **Review Order** button shows cart quantity and opens checkout.

### Checkout (`/order`)
1. Review items, update quantities, or remove entries.
2. Click **Checkout**, fill in Name and Phone (email optional but recommended), then submit.
3. A confirmation banner shows the four-digit order code and the target ready time (~20 minutes).

### Track My Order (`/track`)
1. Enter the email used at checkout (matching is case-insensitive) and the order code.
2. Success redirects to `/track-order-{orderId}` where a timeline displays each step and timestamps.
3. The status chip reflects the latest stage; canceled orders show a dedicated notice.

### Admin Area
- Log in at `/admin-login` using a seeded account (e.g. `test@gmail.com` / `123456`).
- After authentication you land on `/admin-dashboard`, which links to:
  - **See Orders** (`/admin-order`): tabbed list of orders by status with inline progression controls.
  - **Manage Menu** (`/admin-menu`): placeholder for future menu editing.
  - **Manage Profile**: reserved for future enhancements.
- Visit `/logout` to end the session; `/postlogout` confirms sign-out.

---

## Running Locally

### Prerequisites
- .NET 8 SDK
- PostgreSQL database (local or hosted)
- Optional `.env.local` file for secrets (loaded automatically with DotNetEnv)

### Configure the Database
1. Create a PostgreSQL database instance.
2. Update `appsettings.json` or `appsettings.Development.json` with the `TakeawayTitansContext` connection string, or set the `DATABASE_URL` environment variable.
3. Apply migrations if the schema is missing:
   ```bash
   dotnet ef database update --project TakeawayTitans/src/TakeawayTitans.csproj
   ```
4. Seeding runs on startup, populating menu items, demo users, and sample orders.

### Run the App
```bash
cd TakeawayTitans/src
dotnet watch
```
Open `https://localhost:5001` (or the port shown in the console).

---

## Troubleshooting Tips
- **Login issues**: Ensure the seeded password (`123456`) is correct and cookies are enabled. Clear the auth cookie if a stale token persists.
- **Tracking errors**: Confirm the email matches checkout and the four-digit code is correct.
- **Empty menu**: Verify `/api/MenuItems` responds; check database connectivity and migrations.
- **Database failures**: Confirm the PostgreSQL server is reachable and the `DATABASE_URL` or connection string is accurate.

---

## Team
- Min-ting Chuang
- Hayden Call
- Jovanny Andres Rey

---

## Helpful References
- Iconify: https://icon-sets.iconify.design/
- Blazor Bootstrap: https://demos.blazorbootstrap.com/
- Blazor authentication walkthrough: https://youtu.be/CpJh_j88_Lw
