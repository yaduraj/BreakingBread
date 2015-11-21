/*****************************************************************************
* tbl_Address
*****************************************************************************/
CREATE TABLE tbl_Address
(
    AddressId         INT                   NOT NULL PRIMARY KEY,
    UserId            NVARCHAR(256)         NOT NULL,
    Area              NVARCHAR(MAX)         NOT NULL,
    Flat              NVARCHAR(MAX)         NOT NULL,
    Landmark          NVARCHAR(MAX)         NULL,
    City              NVARCHAR(256)         NOT NULL DEFAULT 'HYD'
)