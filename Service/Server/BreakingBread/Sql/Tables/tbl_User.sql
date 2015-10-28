/*****************************************************************************
* tbl_User
*****************************************************************************/
CREATE TABLE tbl_User
(
    UserId                 NVARCHAR(256)         NOT NULL PRIMARY KEY,
    Name                   NVARCHAR(MAX)         NOT NULL,
    Mobile                 BIGINT                NOT NULL,
)
