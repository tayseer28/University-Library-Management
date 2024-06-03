/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     5/21/2023 3:32:28 AM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOK') and o.name = 'FK_BOOK_BELONGS_T_CATEGORY')
alter table BOOK
   drop constraint FK_BOOK_BELONGS_T_CATEGORY
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOK') and o.name = 'FK_BOOK_MANAGE_ADMIN')
alter table BOOK
   drop constraint FK_BOOK_MANAGE_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOK') and o.name = 'FK_BOOK_PUBLISH_PUBLISHE')
alter table BOOK
   drop constraint FK_BOOK_PUBLISH_PUBLISHE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOK_AUTHOR') and o.name = 'FK_BOOK_AUT_BOOK_AUTH_AUTHOR')
alter table BOOK_AUTHOR
   drop constraint FK_BOOK_AUT_BOOK_AUTH_AUTHOR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOK_AUTHOR') and o.name = 'FK_BOOK_AUT_BOOK_AUTH_BOOK')
alter table BOOK_AUTHOR
   drop constraint FK_BOOK_AUT_BOOK_AUTH_BOOK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('COPY') and o.name = 'FK_COPY_HAS_BOOK')
alter table COPY
   drop constraint FK_COPY_HAS_BOOK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('STUDENT_COPY') and o.name = 'FK_STUDENT__STUDENT_C_STUDENT')
alter table STUDENT_COPY
   drop constraint FK_STUDENT__STUDENT_C_STUDENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('STUDENT_COPY') and o.name = 'FK_STUDENT__STUDENT_C_COPY')
alter table STUDENT_COPY
   drop constraint FK_STUDENT__STUDENT_C_COPY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN')
            and   type = 'U')
   drop table ADMIN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AUTHOR')
            and   type = 'U')
   drop table AUTHOR
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOK')
            and   name  = 'PUBLISH_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOK.PUBLISH_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOK')
            and   name  = 'MANAGE_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOK.MANAGE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOK')
            and   name  = 'BELONGS_TO_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOK.BELONGS_TO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOOK')
            and   type = 'U')
   drop table BOOK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOK_AUTHOR')
            and   name  = 'BOOK_AUTHOR2_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOK_AUTHOR.BOOK_AUTHOR2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOK_AUTHOR')
            and   name  = 'BOOK_AUTHOR_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOK_AUTHOR.BOOK_AUTHOR_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOOK_AUTHOR')
            and   type = 'U')
   drop table BOOK_AUTHOR
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CATEGORY')
            and   type = 'U')
   drop table CATEGORY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('COPY')
            and   type = 'U')
   drop table COPY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBLISHER')
            and   type = 'U')
   drop table PUBLISHER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('STUDENT')
            and   type = 'U')
   drop table STUDENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('STUDENT_COPY')
            and   name  = 'STUDENT_COPY2_FK'
            and   indid > 0
            and   indid < 255)
   drop index STUDENT_COPY.STUDENT_COPY2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('STUDENT_COPY')
            and   name  = 'STUDENT_COPY_FK'
            and   indid > 0
            and   indid < 255)
   drop index STUDENT_COPY.STUDENT_COPY_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('STUDENT_COPY')
            and   type = 'U')
   drop table STUDENT_COPY
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   ADMINID              int                  not null,
   FNAME                varchar(50)          not null,
   LNAME                varchar(50)          not null,
   EMAIL                varchar(125)         not null,
   PASSWORD             varchar(12)          not null,
   constraint PK_ADMIN primary key nonclustered (ADMINID)
)
go

/*==============================================================*/
/* Table: AUTHOR                                                */
/*==============================================================*/
create table AUTHOR (
   AUTHORID             int                  not null,
   NAME                 varchar(1024)        not null,
   constraint PK_AUTHOR primary key nonclustered (AUTHORID)
)
go

/*==============================================================*/
/* Table: BOOK                                                  */
/*==============================================================*/
create table BOOK (
   BOOKID               int                  not null,
   CATEGORYID           int                  not null,
   PUBLISHERID          int                  not null,
   ADMINID              int                  not null,
   TITLE                varchar(1024)        not null,
   ISBN                 varchar(25)          not null,
   PUBLICATIONYEAR      int                  not null,
   constraint PK_BOOK primary key nonclustered (BOOKID)
)
go

/*==============================================================*/
/* Index: BELONGS_TO_FK                                         */
/*==============================================================*/
create index BELONGS_TO_FK on BOOK (
CATEGORYID ASC
)
go

/*==============================================================*/
/* Index: MANAGE_FK                                             */
/*==============================================================*/
create index MANAGE_FK on BOOK (
ADMINID ASC
)
go

/*==============================================================*/
/* Index: PUBLISH_FK                                            */
/*==============================================================*/
create index PUBLISH_FK on BOOK (
PUBLISHERID ASC
)
go

/*==============================================================*/
/* Table: BOOK_AUTHOR                                           */
/*==============================================================*/
create table BOOK_AUTHOR (
   AUTHORID             int                  not null,
   BOOKID               int                  not null,
   constraint PK_BOOK_AUTHOR primary key (AUTHORID, BOOKID)
)
go

/*==============================================================*/
/* Index: BOOK_AUTHOR_FK                                        */
/*==============================================================*/
create index BOOK_AUTHOR_FK on BOOK_AUTHOR (
AUTHORID ASC
)
go

/*==============================================================*/
/* Index: BOOK_AUTHOR2_FK                                       */
/*==============================================================*/
create index BOOK_AUTHOR2_FK on BOOK_AUTHOR (
BOOKID ASC
)
go

/*==============================================================*/
/* Table: CATEGORY                                              */
/*==============================================================*/
create table CATEGORY (
   CATEGORYID           int                  not null,
   CATEGORYNAME         varchar(255)         not null,
   constraint PK_CATEGORY primary key nonclustered (CATEGORYID)
)
go

/*==============================================================*/
/* Table: COPY                                                  */
/*==============================================================*/
create table COPY (
   BOOKID               int                  not null,
   COPYNUM              int                  not null,
   STATUS               bit                  not null,
   NUMOFCOPIES          int                  not null,
   constraint PK_COPY primary key (BOOKID, COPYNUM)
)
go

/*==============================================================*/
/* Table: PUBLISHER                                             */
/*==============================================================*/
create table PUBLISHER (
   PUBLISHERID          int                  not null,
   NAME                 varchar(1024)        not null,
   constraint PK_PUBLISHER primary key nonclustered (PUBLISHERID)
)
go

/*==============================================================*/
/* Table: STUDENT                                               */
/*==============================================================*/
create table STUDENT (
   STUDENTID            int                  not null,
   FNAME                varchar(50)          not null,
   LNAME                varchar(50)          not null,
   EMAIL                varchar(125)         not null,
   PASSWORD             varchar(12)          not null,
   STUDYYEAR            smallint             not null,
   DEPARTMENT           varchar(2)           not null,
   REGISTERDATE         datetime             null,
   constraint PK_STUDENT primary key nonclustered (STUDENTID)
)
go

/*==============================================================*/
/* Table: STUDENT_COPY                                          */
/*==============================================================*/
create table STUDENT_COPY (
   BOOKID               int                  not null,
   COPYNUM              int                  not null,
   STUDENTID            int                  not null,
   BORROWDATE           datetime             not null,
   RETURNDATE           datetime             not null,
   constraint PK_STUDENT_COPY primary key (BOOKID, COPYNUM, STUDENTID)
)
go

/*==============================================================*/
/* Index: STUDENT_COPY_FK                                       */
/*==============================================================*/
create index STUDENT_COPY_FK on STUDENT_COPY (
STUDENTID ASC
)
go

/*==============================================================*/
/* Index: STUDENT_COPY2_FK                                      */
/*==============================================================*/
create index STUDENT_COPY2_FK on STUDENT_COPY (
BOOKID ASC,
COPYNUM ASC
)
go

alter table BOOK
   add constraint FK_BOOK_BELONGS_T_CATEGORY foreign key (CATEGORYID)
      references CATEGORY (CATEGORYID)
go

alter table BOOK
   add constraint FK_BOOK_MANAGE_ADMIN foreign key (ADMINID)
      references ADMIN (ADMINID)
go

alter table BOOK
   add constraint FK_BOOK_PUBLISH_PUBLISHE foreign key (PUBLISHERID)
      references PUBLISHER (PUBLISHERID)
go

alter table BOOK_AUTHOR
   add constraint FK_BOOK_AUT_BOOK_AUTH_AUTHOR foreign key (AUTHORID)
      references AUTHOR (AUTHORID)
go

alter table BOOK_AUTHOR
   add constraint FK_BOOK_AUT_BOOK_AUTH_BOOK foreign key (BOOKID)
      references BOOK (BOOKID)
go

alter table COPY
   add constraint FK_COPY_HAS_BOOK foreign key (BOOKID)
      references BOOK (BOOKID)
go

alter table STUDENT_COPY
   add constraint FK_STUDENT__STUDENT_C_STUDENT foreign key (STUDENTID)
      references STUDENT (STUDENTID)
go

alter table STUDENT_COPY
   add constraint FK_STUDENT__STUDENT_C_COPY foreign key (BOOKID, COPYNUM)
      references COPY (BOOKID, COPYNUM)
go

