-- ============================================================
--  Pizza Ordering System — MySQL Database Schema
-- ============================================================

-- Create and select the database
CREATE DATABASE IF NOT EXISTS pizza_db
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_unicode_ci;

USE pizza_db;

-- --------------------------------------------------------
--  Table: orders
--  Stores customer info + payment summary for each order
-- --------------------------------------------------------
CREATE TABLE IF NOT EXISTS orders (
    order_id        INT             NOT NULL AUTO_INCREMENT,

    -- Customer Information
    first_name      VARCHAR(100)    NOT NULL,
    last_name       VARCHAR(100)    NOT NULL,
    address         VARCHAR(255)    NOT NULL,
    province        VARCHAR(100)    NOT NULL,
    city            VARCHAR(100)    NOT NULL,
    postal_code     VARCHAR(20)     NOT NULL,
    contact_no      VARCHAR(30)         NULL,
    email           VARCHAR(150)        NULL,

    -- Payment Information
    payment_method  VARCHAR(50)     NOT NULL,
    card_no         VARCHAR(100)        NULL,   -- NULL when paying by Cash

    -- Totals
    subtotal        DECIMAL(10,2)   NOT NULL DEFAULT 0.00,
    hst             DECIMAL(10,2)   NOT NULL DEFAULT 0.00,
    total_due       DECIMAL(10,2)   NOT NULL DEFAULT 0.00,
    amount_paid     DECIMAL(10,2)   NOT NULL DEFAULT 0.00,
    change_amount   DECIMAL(10,2)   NOT NULL DEFAULT 0.00,

    -- Timestamp
    order_date      DATETIME        NOT NULL DEFAULT CURRENT_TIMESTAMP,

    PRIMARY KEY (order_id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;


-- --------------------------------------------------------
--  Table: order_items
--  Stores each line item that belongs to an order
-- --------------------------------------------------------
CREATE TABLE IF NOT EXISTS order_items (
    item_id     INT             NOT NULL AUTO_INCREMENT,
    order_id    INT             NOT NULL,
    item_name   VARCHAR(150)    NOT NULL,
    quantity    INT             NOT NULL DEFAULT 1,
    price       DECIMAL(10,2)  NOT NULL DEFAULT 0.00,

    PRIMARY KEY (item_id),

    -- Foreign key back to the parent order
    CONSTRAINT fk_order_items_order
        FOREIGN KEY (order_id)
        REFERENCES orders (order_id)
        ON DELETE CASCADE
        ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
