/*****************************************************************************
* tbl_Order
*****************************************************************************/
CREATE TABLE tbl_Order
(
    OrderId                INT                   NOT NULL PRIMARY KEY,
    UserId                 NVARCHAR(256)         NOT NULL,
    AddressId              INT                   NOT NULL,
    DeliveryDate           DATETIME              NOT NULL,
    DeliveryTime           DATETIME              NOT NULL,
    MenuId                 INT                   NOT NULL,
    PaymentMethod          NVARCHAR              NOT NULL DEFAULT 'COD'
    
)
