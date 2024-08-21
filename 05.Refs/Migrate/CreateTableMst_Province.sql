DROP TABLE Mst_Province
	
CREATE TABLE Mst_Province (
       ProvinceCode         nvarchar(50) NOT NULL,
       ProvinceName         nvarchar(200) NOT NULL,
       FlagActive           nvarchar(10) NOT NULL,
       Remark               nvarchar(400) NULL,
)

ALTER TABLE Mst_Province
       ADD CONSTRAINT XPKMst_Province PRIMARY KEY CLUSTERED (
              ProvinceCode ASC)