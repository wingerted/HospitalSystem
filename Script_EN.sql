/*CREATE SCHEMA `EvilData` ;*/

SET FOREIGN_KEY_CHECKS=0;


CREATE TABLE Adjust_Price_Record
(
	AdjustPriceRecordID BIGINT NOT NULL AUTO_INCREMENT,
	MedicineID BIGINT,
	DoctorID BIGINT,
	MedicineOldPrice DOUBLE,
	MedicineCurrentPrice DOUBLE,
	AdjustPriceDate DATE,
	PRIMARY KEY (AdjustPriceRecordID),
	KEY (MedicineID),
	KEY (DoctorID)

) 
;


CREATE TABLE Allocate_Record
(
	AllocateRecordID BIGINT NOT NULL AUTO_INCREMENT,
	MedicineID BIGINT,
	DoctorID BIGINT,
	AllocateType CHAR(5),
	AllocateDate DATE,
	AllocateReason VARCHAR(50),
	AllocateNumber INTEGER,
	PRIMARY KEY (AllocateRecordID),
	KEY (MedicineID),
	KEY (DoctorID)

) 
;


CREATE TABLE Examine_List
(
	ExamineListID BIGINT NOT NULL AUTO_INCREMENT,
	PatientID BIGINT,
	PRIMARY KEY (ExamineListID),
	KEY (PatientID)
) 
;


CREATE TABLE Examine_Detail
(
	ExamineDetailID BIGINT NOT NULL AUTO_INCREMENT,
	ExamineListID BIGINT,
	ProductID BIGINT,
	ExamineDoctorID BIGINT,
	ExamineResult VARCHAR(50),
	ExamineTime DATETIME,
	PRIMARY KEY (ExamineDetailID),
	KEY (ExamineListID),
	KEY (ProductID),
	KEY (ExamineDoctorID)
) 
;


CREATE TABLE Examine_Product
(
	ProductID BIGINT NOT NULL AUTO_INCREMENT,
	ProductName VARCHAR(50),
	ProductDescribe VARCHAR(50),
	ProductPrice DOUBLE,
	PRIMARY KEY (ProductID)

) 
;


CREATE TABLE Department
(
	DepartmentID BIGINT NOT NULL AUTO_INCREMENT,
	DepartmentName VARCHAR(50),
	DepartmentDescribe VARCHAR(50),
	PRIMARY KEY (DepartmentID)

) 
;


CREATE TABLE Staff
(
	StaffID BIGINT NOT NULL AUTO_INCREMENT,
	StaffName VARCHAR(50),
	StaffPassword VARCHAR(50),
	Gender CHAR(5),
	Birthday DATE,
	Job VARCHAR(50),
	PRIMARY KEY (StaffID)

) 
;


CREATE TABLE Register_List
(
	RegisterID BIGINT NOT NULL AUTO_INCREMENT,
	PatientID BIGINT,
	StaffID BIGINT,
	DepartmentID BIGINT,
	DoctorID BIGINT,
	RegisterTime DATETIME,
	PRIMARY KEY (RegisterID),
	KEY (DepartmentID),
	KEY (StaffID),
	KEY (PatientID),
	KEY (DoctorID)

) 
;


CREATE TABLE Medicine_Record
(
	MedicineRecordID BIGINT NOT NULL AUTO_INCREMENT,
	PatientID BIGINT,
	DoctorID BIGINT,
	DiseaseDescribe VARCHAR(50),
	TreatTime DATETIME,
	PRIMARY KEY (MedicineRecordID),
	KEY (PatientID),
	KEY (DoctorID)

) 
;


CREATE TABLE Patient
(
	PatientID BIGINT NOT NULL AUTO_INCREMENT,
	Name VARCHAR(50),
	Birthday DATE,
	Gender CHAR(5),
	Telephone VARCHAR(50),
	PRIMARY KEY (PatientID)

) 
;


CREATE TABLE Purchase_Record
(
	PurchaseRecordID BIGINT NOT NULL AUTO_INCREMENT,
	MedicineID BIGINT,
	StaffID BIGINT,
	MedicineNumber INTEGER,
	MedicinePrice DOUBLE,
	PurchaseDate DATE,
	PRIMARY KEY (PurchaseRecordID),
	KEY (StaffID),
	KEY (MedicineID)

) 
;


CREATE TABLE Outbound_Record
(
	OutboundRecordID BIGINT NOT NULL AUTO_INCREMENT,
	MedicineID BIGINT,
	StaffID BIGINT,
	MedicineNumber INTEGER,
	OutboundDate DATE,
	PRIMARY KEY (OutboundRecordID),
	KEY (StaffID),
	KEY (MedicineID)

) 
;


CREATE TABLE Inbound_Record
(
	InboundRecordID BIGINT NOT NULL AUTO_INCREMENT,
	MedicineID BIGINT,
	StaffID BIGINT,
	MedicineNumber INTEGER,
	ManufactureDate DATE,
	InboundDate DATE,
	PRIMARY KEY (InboundRecordID),
	KEY (StaffID),
	KEY (MedicineID)

) 
;


CREATE TABLE Charge_Record
(
	ChargeRecordID BIGINT NOT NULL AUTO_INCREMENT,
	PatientID BIGINT,
	PrescriptionID BIGINT,
	ExamineListID BIGINT,
	StaffID BIGINT,
	SumPay DOUBLE,
	ChargeDate DATE,
	PRIMARY KEY (ChargeRecordID),
	KEY (PatientID),
	KEY (PrescriptionID),
	KEY (ExamineListID),
	KEY (StaffID)

) 
;


CREATE TABLE Approve_Record
(
	ApproveRecordID BIGINT NOT NULL AUTO_INCREMENT,
	MedicineID BIGINT,
	ApplyDoctorID BIGINT,
	ApproveDoctorID BIGINT,
	MedicineNumber INTEGER,
	ApplyReason VARCHAR(50),
	ApplyTime DATETIME,
	ApproveTime DATETIME,
	Pass BOOL,
	PRIMARY KEY (ApproveRecordID),
	KEY (MedicineID)

) 
;


CREATE TABLE Withdraw_Registration_Record
(
	WithdrawRegistrationRecordID BIGINT NOT NULL AUTO_INCREMENT,
	PatientID BIGINT,
	DepartmentID BIGINT,
	StaffID BIGINT,
	DoctorID BIGINT,
	RegisterTime DATETIME,
	PRIMARY KEY (WithdrawRegistrationRecordID),
	KEY (StaffID),
	KEY (PatientID),
	KEY (DepartmentID)

) 
;


CREATE TABLE Withdraw_Medicine_Record
(
	WithdrawMedicineRecordID BIGINT NOT NULL AUTO_INCREMENT,
	MedicineID BIGINT,
	PatientID BIGINT,
	StaffID BIGINT,
	MedicineNumber INTEGER,
	WithdrawMedicineDate DATE,
	PRIMARY KEY (WithdrawMedicineRecordID),
	KEY (MedicineID),
	KEY (PatientID),
	KEY (StaffID)

) 
;


CREATE TABLE Appointment_Record
(
	AppointmentID BIGINT NOT NULL AUTO_INCREMENT,
	DoctorID BIGINT,
	PatientID BIGINT,
	AppointmentTime DATETIME,
	PRIMARY KEY (AppointmentID),
	KEY (PatientID),
	KEY (DoctorID)

) 
;


CREATE TABLE Prescription
(
	PrescriptionID BIGINT NOT NULL AUTO_INCREMENT,
	MedicineRecordID BIGINT,
	PRIMARY KEY (PrescriptionID),
	KEY (MedicineRecordID)

) 
;


CREATE TABLE Medicine
(
	MedicineID BIGINT NOT NULL,
	MedicineName VARCHAR(50),
	MedicinePrice DOUBLE,
	Manufacturer VARCHAR(50),
	Supplier VARCHAR(50),
	PackageCompany VARCHAR(50),
	DispensingCompany VARCHAR(50),
	Poison BOOL,
	Psychotic BOOL,
	Precious BOOL,
	MakeSelf BOOL,
	Entrance BOOL,
	PaySelf BOOL,
	ValidityDate DATE,
	MaxNumber INTEGER,
	PRIMARY KEY (MedicineID)

) 
;


CREATE TABLE Medicine_Inventory
(
	MedicineInventoryID BIGINT NOT NULL AUTO_INCREMENT,
	MedicineID BIGINT,
	ManufactureDate DATE,
	InventoryNumber INTEGER,
	PRIMARY KEY (MedicineInventoryID),
	KEY (MedicineID)

) 
;


CREATE TABLE Medicine_Detail
(
	MedicineDetailID BIGINT NOT NULL AUTO_INCREMENT,
	MedicineID BIGINT,
	PrescriptionID BIGINT,
	MedicineNumber INTEGER,
	PRIMARY KEY (MedicineDetailID),
	KEY (PrescriptionID),
	KEY (MedicineID)

) 
;


CREATE TABLE Doctor
(
	DoctorID BIGINT NOT NULL AUTO_INCREMENT,
	DepartmentID BIGINT,
	DoctorPassword VARCHAR(50),
	DoctorName VARCHAR(50),
	DoctorGender CHAR(5),
	Expert BOOL,
	Title VARCHAR(50),
	PRIMARY KEY (DoctorID),
	KEY (DepartmentID)

) 
;



SET FOREIGN_KEY_CHECKS=1;


ALTER TABLE Adjust_Price_Record ADD CONSTRAINT FK_AdjustPriceRecord_Medicine 
	FOREIGN KEY (MedicineID) REFERENCES Medicine (MedicineID)
;

ALTER TABLE Adjust_Price_Record ADD CONSTRAINT FK_AdjustPriceRecord_Doctor 
	FOREIGN KEY (DoctorID) REFERENCES Doctor (DoctorID)
;

ALTER TABLE Allocate_Record ADD CONSTRAINT FK_AllocateRecord_Medicine 
	FOREIGN KEY (MedicineID) REFERENCES Medicine (MedicineID)
;

ALTER TABLE Allocate_Record ADD CONSTRAINT FK_AllocateRecord_Doctor 
	FOREIGN KEY (DoctorID) REFERENCES Doctor (DoctorID)
;

ALTER TABLE Examine_List ADD CONSTRAINT FK_ExamineList_Patient 
	FOREIGN KEY (PatientID) REFERENCES Medicine_Record (PatientID)
;

ALTER TABLE Examine_Detail ADD CONSTRAINT FK_ExamineDetail_ExamineList 
	FOREIGN KEY (ExamineListID) REFERENCES Examine_List (ExamineListID)
;

ALTER TABLE Examine_Detail ADD CONSTRAINT FK_ExamineDetail_ExamineProduct 
	FOREIGN KEY (ProductID) REFERENCES Examine_Product (ProductID)
;

ALTER TABLE Examine_Detail ADD CONSTRAINT FK_ExamineDetail_Doctor 
	FOREIGN KEY (ExamineDoctorID) REFERENCES Doctor (DoctorID)
;

ALTER TABLE Register_List ADD CONSTRAINT FK_RegisterList_Department 
	FOREIGN KEY (DepartmentID) REFERENCES Department (DepartmentID)
;

ALTER TABLE Register_List ADD CONSTRAINT FK_RegisterList_Staff 
	FOREIGN KEY (StaffID) REFERENCES Staff (StaffID)
;

ALTER TABLE Register_List ADD CONSTRAINT FK_RegisterList_Patient 
	FOREIGN KEY (PatientID) REFERENCES Patient (PatientID)
;

ALTER TABLE Register_List ADD CONSTRAINT FK_RegisterList_Doctor 
	FOREIGN KEY (DoctorID) REFERENCES Doctor (DoctorID)
;

ALTER TABLE Medicine_Record ADD CONSTRAINT FK_MedicineRecord_Patient 
	FOREIGN KEY (PatientID) REFERENCES Patient (PatientID)
;

ALTER TABLE Medicine_Record ADD CONSTRAINT FK_MedicineRecord_Doctor 
	FOREIGN KEY (DoctorID) REFERENCES Doctor (DoctorID)
;

ALTER TABLE Purchase_Record ADD CONSTRAINT FK_PurchaseRecord_Staff 
	FOREIGN KEY (StaffID) REFERENCES Staff (StaffID)
;

ALTER TABLE Purchase_Record ADD CONSTRAINT FK_PurchaseRecord_Medicine 
	FOREIGN KEY (MedicineID) REFERENCES Medicine (MedicineID)
;

ALTER TABLE Outbound_Record ADD CONSTRAINT FK_OutboundRecord_Staff 
	FOREIGN KEY (StaffID) REFERENCES Staff (StaffID)
;

ALTER TABLE Outbound_Record ADD CONSTRAINT FK_OutboundRecord_Medicine 
	FOREIGN KEY (MedicineID) REFERENCES Medicine (MedicineID)
;

ALTER TABLE Inbound_Record ADD CONSTRAINT FK_InboundRecord_Staff 
	FOREIGN KEY (StaffID) REFERENCES Staff (StaffID)
;

ALTER TABLE Inbound_Record ADD CONSTRAINT FK_InboundRecord_Medicine 
	FOREIGN KEY (MedicineID) REFERENCES Medicine (MedicineID)
;

ALTER TABLE Charge_Record ADD CONSTRAINT FK_ChargeRecord_Patient 
	FOREIGN KEY (PatientID) REFERENCES Patient (PatientID)
;

ALTER TABLE Charge_Record ADD CONSTRAINT FK_ChargeRecord_Prescription 
	FOREIGN KEY (PrescriptionID) REFERENCES Prescription (PrescriptionID)
;

ALTER TABLE Charge_Record ADD CONSTRAINT FK_ChargeRecord_ExamineList 
	FOREIGN KEY (ExamineListID) REFERENCES Examine_List (ExamineListID)
;

ALTER TABLE Charge_Record ADD CONSTRAINT FK_ChargeRecord_Staff 
	FOREIGN KEY (StaffID) REFERENCES Staff (StaffID)
;

ALTER TABLE Approve_Record ADD CONSTRAINT FK_ApproveRecord_Medicine 
	FOREIGN KEY (MedicineID) REFERENCES Medicine (MedicineID)
;

ALTER TABLE Approve_Record ADD CONSTRAINT FK_ApproveRecord_Doctor_Apply 
	FOREIGN KEY (ApplyDoctorID) REFERENCES Doctor (DoctorID)
;

ALTER TABLE Approve_Record ADD CONSTRAINT FK_ApproveRecord_Doctor_Approve 
	FOREIGN KEY (ApproveDoctorID) REFERENCES Doctor (DoctorID)
;

ALTER TABLE Withdraw_Registration_Record ADD CONSTRAINT FK_WithdrawRegistrationRecord_Staff 
	FOREIGN KEY (StaffID) REFERENCES Staff (StaffID)
;

ALTER TABLE Withdraw_Registration_Record ADD CONSTRAINT FK_WithdrawRegistrationRecord_Patient 
	FOREIGN KEY (PatientID) REFERENCES Patient (PatientID)
;

ALTER TABLE Withdraw_Registration_Record ADD CONSTRAINT FK_WithdrawRegistrationRecord_Department 
	FOREIGN KEY (DepartmentID) REFERENCES Department (DepartmentID)
;

ALTER TABLE Withdraw_Medicine_Record ADD CONSTRAINT FK_WithdrawMedicineRecord_Medicine 
	FOREIGN KEY (MedicineID) REFERENCES Medicine (MedicineID)
;

ALTER TABLE Withdraw_Medicine_Record ADD CONSTRAINT FK_WithdrawMedicineRecord_Patient 
	FOREIGN KEY (PatientID) REFERENCES Patient (PatientID)
;

ALTER TABLE Withdraw_Medicine_Record ADD CONSTRAINT FK_WithdrawMedicineRecord_Staff 
	FOREIGN KEY (StaffID) REFERENCES Staff (StaffID)
;

ALTER TABLE Appointment_Record ADD CONSTRAINT FK_AppointmentRecord_Patient 
	FOREIGN KEY (PatientID) REFERENCES Patient (PatientID)
;

ALTER TABLE Appointment_Record ADD CONSTRAINT FK_AppointmentRecord_Doctor 
	FOREIGN KEY (DoctorID) REFERENCES Doctor (DoctorID)
;

ALTER TABLE Prescription ADD CONSTRAINT FK_Prescription_MedicineRecord 
	FOREIGN KEY (MedicineRecordID) REFERENCES Medicine_Record (MedicineRecordID)
;

ALTER TABLE Medicine_Inventory ADD CONSTRAINT FK_MedicineInventory_Medicine 
	FOREIGN KEY (MedicineID) REFERENCES Medicine (MedicineID)
;

ALTER TABLE Medicine_Detail ADD CONSTRAINT FK_MedicineDetail_Prescription 
	FOREIGN KEY (PrescriptionID) REFERENCES Prescription (PrescriptionID)
;

ALTER TABLE Medicine_Detail ADD CONSTRAINT FK_MedicineDetail_Medicine 
	FOREIGN KEY (MedicineID) REFERENCES Medicine (MedicineID)
;

ALTER TABLE Doctor ADD CONSTRAINT FK_Doctor_Department 
	FOREIGN KEY (DepartmentID) REFERENCES Department (DepartmentID)
;



insert into Department(DepartmentName,DepartmentDescribe)
values('胃肠科','胃肠科是本院热门诊室');

insert into Department(DepartmentName,DepartmentDescribe)
values('皮肤科','皮肤科是普通Department');

insert into Department(DepartmentName,DepartmentDescribe)
values('内科','内科是普通Department');

insert into Department(DepartmentName,DepartmentDescribe)
values('X光检查','ExamineDepartment是普通Department');



insert into Doctor(DepartmentID,DoctorName,DoctorPassword,DoctorGender,Expert,Title)
values('1','张三','1234','男',0,'医师');

insert into Doctor(DepartmentID,DoctorName,DoctorPassword,DoctorGender,Expert,Title)
values('1','丁小一','1234','女',1,'副主任');

insert into Doctor(DepartmentID,DoctorName,DoctorPassword,DoctorGender,Expert,Title)
values('1','马晓明','1234','男',1,'主任');

insert into Doctor(DepartmentID,DoctorName,DoctorPassword,DoctorGender,Expert,Title)
values('2','刘潇','1234','女',0,'医师');

insert into Doctor(DepartmentID,DoctorName,DoctorPassword,DoctorGender,Expert,Title)
values('3','张小小','1234','男',0,'医师');

insert into Doctor(DepartmentID,DoctorName,DoctorPassword,DoctorGender,Expert,Title)
values('4','王二','1234','男',0,'胃肠科ExamineDepartment医师');

insert into Doctor(DepartmentID,DoctorName,DoctorPassword,DoctorGender,Expert,Title)
values('1','鲁直','1234','男',1,'院长');



insert into Patient(Name,Birthday,Gender,Telephone)
values('陈小强','1992-01-04','男','13112122222');

insert into Patient(Name,Birthday,Gender,Telephone)
values('李丽','1942-11-24','女','13524534543');

insert into Patient(Name,Birthday,Gender,Telephone)
values('何小','1972-06-22','男','13498534890');



insert into Staff(StaffName,StaffPassword,Gender,Birthday,Job)
values('张强','1234','男','1988-02-22','窗口Staff');

insert into Staff(StaffName,StaffPassword,Gender,Birthday,Job)
values('印赫','1234','男','1979-12-02','药房管理人员');

insert into Staff(StaffName,StaffPassword,Gender,Birthday,Job)
values('刘来','1234','女','1983-10-12','药房Staff');

insert into Staff(StaffName,StaffPassword,Gender,Birthday,Job)
values('程舞','1234','女','1988-01-07','护士台Staff');



insert into Medicine(MedicineID,MedicineName,MedicinePrice,Manufacturer,Supplier,PackageCompany,DispensingCompany,PaySelf,ValidityDate,MaxNumber)
values('11130483','猴头菌片',4.8,'山西云鹏制药有限公司','山西云鹏制药有限公司','山西云鹏制药有限公司','山西云鹏制药有限公司',1,'0001-00-00',1200);

insert into Medicine(MedicineID,MedicineName,MedicinePrice,Manufacturer,Supplier,PackageCompany,DispensingCompany,Entrance,ValidityDate,MaxNumber)
values('20050116','头孢美唑钠',1035,'SHIN POONG Pharmaceutical Co LTD','SHIN POONG Pharmaceutical Co.,LTD','SHIN POONG Pharmaceutical Co.,LTD','SHIN POONG Pharmaceutical Co.,LTD',1,'0002-00-00',50);

insert into Medicine(MedicineID,MedicineName,MedicinePrice,Manufacturer,Supplier,PackageCompany,DispensingCompany,Poison,ValidityDate,MaxNumber)
values('30330779','吗啡',500,'萌蒂(中国)制药有限公司','萌蒂(中国)制药有限公司','萌蒂(中国)制药有限公司','萌蒂(中国)制药有限公司',1,'0002-00-00',50);

insert into Medicine(MedicineID,MedicineName,MedicinePrice,Manufacturer,Supplier,PackageCompany,DispensingCompany,ValidityDate,MaxNumber)
values('42022844','阿司匹林肠溶片',2.31,'武汉同济泰乐奇医药有限公司','武汉同济泰乐奇医药有限公司','武汉同济泰乐奇医药有限公司','武汉同济泰乐奇医药有限公司','0002-00-00',500);



insert into Medicine_Record(PatientID,DoctorID,DiseaseDescribe,TreatTime)
values(1,1,'胃穿孔','2013-06-06');

insert into Prescription(MedicineRecordID)
values(1);

insert into Medicine_Detail(MedicineID,PrescriptionID,MedicineNumber)
values(11130483,1,3);



insert into Register_List(PatientID,StaffID,DepartmentID,DoctorID,RegisterTime)
values(1,1,1,1,'2013-06-06');



insert into Examine_List(PatientID)
values(1);



insert into Charge_Record(PatientID,PrescriptionID,ExamineListID,StaffID,SumPay,ChargeDate)
values(1,1,1,1,549.00,'2013-06-06');



insert into Examine_Product(ProductName,ProductDescribe,ProductPrice)
values('胃镜检查','通过胃镜检查Expert胃部有穿孔现象',300);



insert into Examine_Detail(ExamineListID,ProductID,ExamineDoctorID,ExamineResult,ExamineTime)
values(1,1,6,'胃部右下方有直径1cm胃穿孔','2013-06-06');



insert into Medicine_Inventory(MedicineID,ManufactureDate,InventoryNumber)
values('11130483','2013-06-11',972);

insert into Medicine_Inventory(MedicineID,ManufactureDate,InventoryNumber)
values('20050116','2013-02-16',38);

insert into Medicine_Inventory(MedicineID,ManufactureDate,InventoryNumber)
values('30330779','2013-03-21',25);

insert into Medicine_Inventory(MedicineID,ManufactureDate,InventoryNumber)
values('42022844','2013-02-01',423);



insert into Adjust_Price_Record(MedicineID,DoctorID,MedicineOldPrice,MedicineCurrentPrice,AdjustPriceDate)
values('42022844',7,2.31,2.48,'2013-02-07');



insert into Allocate_Record(MedicineID,DoctorID,AllocateType,AllocateDate,AllocateReason,AllocateNumber)
values('42022844',7,'出','2013-04-10','地方医院急缺',100);



insert into Withdraw_Registration_Record(PatientID,DepartmentID,StaffID,DoctorID,RegisterTime)
values(1,1,1,3,'2013-06-04');



insert into Withdraw_Medicine_Record(MedicineID,PatientID,StaffID,MedicineNumber,WithdrawMedicineDate)
values(42022844,1,3,1,'2013-06-07');



insert into Purchase_Record(MedicineID,StaffID,MedicineNumber,MedicinePrice,PurchaseDate)
values(42022844,2,50,2.31,'2013-02-22');



insert into Appointment_Record(DoctorID,PatientID,AppointmentTime)
values(3,1,'2013-06-05');

insert into Inbound_Record(MedicineID,StaffID,MedicineNumber,ManufactureDate,InboundDate)
values('20050116',2,10,'2013-01-01','2013-06-25');



insert into Outbound_Record(MedicineID,StaffID,MedicineNumber,OutboundDate)
values('20050116',2,1,'2013-06-26');



insert into Approve_Record(MedicineID,ApplyDoctorID,ApproveDoctorID,MedicineNumber,ApplyReason,ApplyTime,ApproveTime,Pass)
values('30330779',1,7,5,'癌症Patient需要吗啡止痛','2013-06-01','2013-06-03',1);



