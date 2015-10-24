/*****************************************************************************
* tbl_Menu
*****************************************************************************/
CREATE TABLE tbl_Menu
(
    MenuId                INT                      NOT NULL PRIMARY KEY,
    Image                 Image                    NOT NULL,
    Text                  NVARCHAR(MAX)            NOT NULL,
    Price                 INT                      NOT NULL,
    Type                  NVARCHAR(256)            NOT NULL DEFAULT 'VEG'
)
