/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     17/05/2024 12:13:53                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ADMINPHONE') and o.name = 'FK_ADMINPHO_OBTAIN_ADMIN')
alter table ADMINPHONE
   drop constraint FK_ADMINPHO_OBTAIN_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOKCOPY') and o.name = 'FK_BOOKCOPY_HAS_BOOK')
alter table BOOKCOPY
   drop constraint FK_BOOKCOPY_HAS_BOOK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BORROW') and o.name = 'FK_BORROW_BORROWED_BOOK')
alter table BORROW
   drop constraint FK_BORROW_BORROWED_BOOK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BORROW') and o.name = 'FK_BORROW_USERBORRO_THEUSER')
alter table BORROW
   drop constraint FK_BORROW_USERBORRO_THEUSER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('COLLEGE_SECTION') and o.name = 'FK_COLLEGE__CONSISTS__LIBRARY')
alter table COLLEGE_SECTION
   drop constraint FK_COLLEGE__CONSISTS__LIBRARY
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EXIST_IN') and o.name = 'FK_EXIST_IN_EXIST_IN_BOOKCOPY')
alter table EXIST_IN
   drop constraint FK_EXIST_IN_EXIST_IN_BOOKCOPY
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EXIST_IN') and o.name = 'FK_EXIST_IN_EXIST_IN2_COLLEGE_')
alter table EXIST_IN
   drop constraint FK_EXIST_IN_EXIST_IN2_COLLEGE_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LIBRARY_BRANCHES') and o.name = 'FK_LIBRARY__OWN_LIBRARY')
alter table LIBRARY_BRANCHES
   drop constraint FK_LIBRARY__OWN_LIBRARY
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MANAGE') and o.name = 'FK_MANAGE_MANAGE_ADMIN')
alter table MANAGE
   drop constraint FK_MANAGE_MANAGE_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MANAGE') and o.name = 'FK_MANAGE_MANAGE2_BOOK')
alter table MANAGE
   drop constraint FK_MANAGE_MANAGE2_BOOK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHONE') and o.name = 'FK_PHONE_ACQUIRE_THEUSER')
alter table PHONE
   drop constraint FK_PHONE_ACQUIRE_THEUSER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN')
            and   type = 'U')
   drop table ADMIN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ADMINPHONE')
            and   name  = 'OBTAIN_FK'
            and   indid > 0
            and   indid < 255)
   drop index ADMINPHONE.OBTAIN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMINPHONE')
            and   type = 'U')
   drop table ADMINPHONE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOOK')
            and   type = 'U')
   drop table BOOK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOOKCOPY')
            and   type = 'U')
   drop table BOOKCOPY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BORROW')
            and   name  = 'USERBORROW_FK'
            and   indid > 0
            and   indid < 255)
   drop index BORROW.USERBORROW_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BORROW')
            and   name  = 'BORROWED_FK'
            and   indid > 0
            and   indid < 255)
   drop index BORROW.BORROWED_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BORROW')
            and   type = 'U')
   drop table BORROW
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('COLLEGE_SECTION')
            and   name  = 'CONSISTS_OF_FK'
            and   indid > 0
            and   indid < 255)
   drop index COLLEGE_SECTION.CONSISTS_OF_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('COLLEGE_SECTION')
            and   type = 'U')
   drop table COLLEGE_SECTION
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EXIST_IN')
            and   name  = 'EXIST_IN2_FK'
            and   indid > 0
            and   indid < 255)
   drop index EXIST_IN.EXIST_IN2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EXIST_IN')
            and   name  = 'EXIST_IN_FK'
            and   indid > 0
            and   indid < 255)
   drop index EXIST_IN.EXIST_IN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EXIST_IN')
            and   type = 'U')
   drop table EXIST_IN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LIBRARY')
            and   type = 'U')
   drop table LIBRARY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LIBRARY_BRANCHES')
            and   type = 'U')
   drop table LIBRARY_BRANCHES
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MANAGE')
            and   name  = 'MANAGE2_FK'
            and   indid > 0
            and   indid < 255)
   drop index MANAGE.MANAGE2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MANAGE')
            and   name  = 'MANAGE_FK'
            and   indid > 0
            and   indid < 255)
   drop index MANAGE.MANAGE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MANAGE')
            and   type = 'U')
   drop table MANAGE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHONE')
            and   name  = 'ACQUIRE_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHONE.ACQUIRE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHONE')
            and   type = 'U')
   drop table PHONE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('THEUSER')
            and   type = 'U')
   drop table THEUSER
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   SSN                  varchar(15)          not null,
   PHONE                varchar(11)          not null,
   LNAME                varchar(20)          not null,
   FNAME                varchar(20)          not null,
   SALARY               float                null,
   BUILDINGNUM          int                  null,
   STREET               varchar(15)          null,
   constraint PK_ADMIN primary key (SSN)
)
go

/*==============================================================*/
/* Table: ADMINPHONE                                            */
/*==============================================================*/
create table ADMINPHONE (
   PHONENUM             varchar(11)          not null,
   SSN                  varchar(15)          not null,
   constraint PK_ADMINPHONE primary key (PHONENUM)
)
go

/*==============================================================*/
/* Index: OBTAIN_FK                                             */
/*==============================================================*/




create nonclustered index OBTAIN_FK on ADMINPHONE (SSN ASC)
go

/*==============================================================*/
/* Table: BOOK                                                  */
/*==============================================================*/
create table BOOK (
   ISBN                 int                  not null,
   AUTHORNAME           varchar(30)          not null,
   TITLE                varchar(45)          not null,
   PUBLISHER            varchar(25)          not null,
   constraint PK_BOOK primary key (ISBN)
)
go

/*==============================================================*/
/* Table: BOOKCOPY                                              */
/*==============================================================*/
create table BOOKCOPY (
   ISBN                 int                  not null,
   COPYID               int                  not null,
   BOOK_STATUS          varchar(23)          not null,
   constraint PK_BOOKCOPY primary key (ISBN)
)
go

/*==============================================================*/
/* Table: BORROW                                                */
/*==============================================================*/
create table BORROW (
   ISBN                 int                  not null,
   USERID               int                  not null,
   BORROWDATE           datetime             not null,
   RETURNDATE           datetime             not null,
   constraint PK_BORROW primary key (ISBN, USERID)
)
go

/*==============================================================*/
/* Index: BORROWED_FK                                           */
/*==============================================================*/




create nonclustered index BORROWED_FK on BORROW (ISBN ASC)
go

/*==============================================================*/
/* Index: USERBORROW_FK                                         */
/*==============================================================*/




create nonclustered index USERBORROW_FK on BORROW (USERID ASC)
go

/*==============================================================*/
/* Table: COLLEGE_SECTION                                       */
/*==============================================================*/
create table COLLEGE_SECTION (
   COLLNAME             varchar(200)         not null,
   LIBRARYID            varchar(15)          not null,
   DEPARTMENT           varchar(200)         null,
   constraint PK_COLLEGE_SECTION primary key (COLLNAME)
)
go

/*==============================================================*/
/* Index: CONSISTS_OF_FK                                        */
/*==============================================================*/




create nonclustered index CONSISTS_OF_FK on COLLEGE_SECTION (LIBRARYID ASC)
go

/*==============================================================*/
/* Table: EXIST_IN                                              */
/*==============================================================*/
create table EXIST_IN (
   ISBN                 int                  not null,
   COLLNAME             varchar(200)         not null,
   constraint PK_EXIST_IN primary key (ISBN, COLLNAME)
)
go

/*==============================================================*/
/* Index: EXIST_IN_FK                                           */
/*==============================================================*/




create nonclustered index EXIST_IN_FK on EXIST_IN (ISBN ASC)
go

/*==============================================================*/
/* Index: EXIST_IN2_FK                                          */
/*==============================================================*/




create nonclustered index EXIST_IN2_FK on EXIST_IN (COLLNAME ASC)
go

/*==============================================================*/
/* Table: LIBRARY                                               */
/*==============================================================*/
create table LIBRARY (
   FNAME                varchar(20)          not null,
   LIBRARYID            varchar(15)          not null,
   constraint PK_LIBRARY primary key (LIBRARYID)
)
go

/*==============================================================*/
/* Table: LIBRARY_BRANCHES                                      */
/*==============================================================*/
create table LIBRARY_BRANCHES (
   LIBRARYID            varchar(15)          not null,
   BRANCHID             varchar(15)          not null,
   LOCATION             varchar(33)          not null,
   constraint PK_LIBRARY_BRANCHES primary key (LIBRARYID)
)
go

/*==============================================================*/
/* Table: MANAGE                                                */
/*==============================================================*/
create table MANAGE (
   SSN                  varchar(15)          not null,
   ISBN                 int                  not null,
   constraint PK_MANAGE primary key (SSN, ISBN)
)
go

/*==============================================================*/
/* Index: MANAGE_FK                                             */
/*==============================================================*/




create nonclustered index MANAGE_FK on MANAGE (SSN ASC)
go

/*==============================================================*/
/* Index: MANAGE2_FK                                            */
/*==============================================================*/




create nonclustered index MANAGE2_FK on MANAGE (ISBN ASC)
go

/*==============================================================*/
/* Table: PHONE                                                 */
/*==============================================================*/
create table PHONE (
   PHONENUMBER          varchar(11)          not null,
   USERID               int                  not null,
   constraint PK_PHONE primary key (PHONENUMBER)
)
go

/*==============================================================*/
/* Index: ACQUIRE_FK                                            */
/*==============================================================*/




create nonclustered index ACQUIRE_FK on PHONE (USERID ASC)
go

/*==============================================================*/
/* Table: THEUSER                                               */
/*==============================================================*/
create table THEUSER (
   USERID               int                  not null,
   UNIEMAIL             varchar(115)         not null,
   FNAME                varchar(20)          not null,
   LNAME                varchar(20)          not null,
   PHONE                varchar(11)          not null,
   CLASSIFICATION       varchar(100)         not null,
   BUILDINGNUM          int                  null,
   STREET               varchar(15)          null,
   constraint PK_THEUSER primary key (USERID)
)
go

alter table ADMINPHONE
   add constraint FK_ADMINPHO_OBTAIN_ADMIN foreign key (SSN)
      references ADMIN (SSN)
go

alter table BOOKCOPY
   add constraint FK_BOOKCOPY_HAS_BOOK foreign key (ISBN)
      references BOOK (ISBN)
go

alter table BORROW
   add constraint FK_BORROW_BORROWED_BOOK foreign key (ISBN)
      references BOOK (ISBN)
go

alter table BORROW
   add constraint FK_BORROW_USERBORRO_THEUSER foreign key (USERID)
      references THEUSER (USERID)
go

alter table COLLEGE_SECTION
   add constraint FK_COLLEGE__CONSISTS__LIBRARY foreign key (LIBRARYID)
      references LIBRARY (LIBRARYID)
go

alter table EXIST_IN
   add constraint FK_EXIST_IN_EXIST_IN_BOOKCOPY foreign key (ISBN)
      references BOOKCOPY (ISBN)
go

alter table EXIST_IN
   add constraint FK_EXIST_IN_EXIST_IN2_COLLEGE_ foreign key (COLLNAME)
      references COLLEGE_SECTION (COLLNAME)
go

alter table LIBRARY_BRANCHES
   add constraint FK_LIBRARY__OWN_LIBRARY foreign key (LIBRARYID)
      references LIBRARY (LIBRARYID)
go

alter table MANAGE
   add constraint FK_MANAGE_MANAGE_ADMIN foreign key (SSN)
      references ADMIN (SSN)
go

alter table MANAGE
   add constraint FK_MANAGE_MANAGE2_BOOK foreign key (ISBN)
      references BOOK (ISBN)
go

alter table PHONE
   add constraint FK_PHONE_ACQUIRE_THEUSER foreign key (USERID)
      references THEUSER (USERID)
go

