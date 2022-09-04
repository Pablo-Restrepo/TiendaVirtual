/*==============================================================*/
/* DBMS name:      ORACLE Version 11g                           */
/* Created on:     4/09/2022 2:17:47 a. m.                      */
/*==============================================================*/


alter table COMPRA
   drop constraint FK_COMPRA_COMPRA_USUARIO;

alter table COMPRA
   drop constraint FK_COMPRA_COMPRA2_PRODUCTO;

alter table GUARDA
   drop constraint FK_GUARDA_GUARDA_USUARIO;

alter table GUARDA
   drop constraint FK_GUARDA_GUARDA2_PRODUCTO;

alter table NOTIFICACION
   drop constraint FK_NOTIFICA_TIENE_USUARIO;

alter table PRODUCTO
   drop constraint FK_PRODUCTO_CREA_USUARIO;

alter table PROMOCIONAL
   drop constraint FK_PROMOCIO_CREA1_USUARIO;

drop index COMPRA2_FK;

drop index COMPRA_FK;

drop table COMPRA cascade constraints;

drop index GUARDA2_FK;

drop index GUARDA_FK;

drop table GUARDA cascade constraints;

drop index TIENE_FK;

drop table NOTIFICACION cascade constraints;

drop index CREA_FK;

drop table PRODUCTO cascade constraints;

drop index CREA1_FK;

drop table PROMOCIONAL cascade constraints;

drop table USUARIO cascade constraints;

/*==============================================================*/
/* Table: COMPRA                                                */
/*==============================================================*/
create table COMPRA 
(
   COM_ID               INTEGER              not null,
   USU_USERNAME         VARCHAR2(15)         not null,
   PRO_ID               INTEGER              not null,
   COM_FECHA            DATE                 not null,
   COM_TOTAL            FLOAT,
   COM_CANTIDAD         INTEGER,
   constraint PK_COMPRA primary key (COM_ID)
);

/*==============================================================*/
/* Index: COMPRA_FK                                             */
/*==============================================================*/
create index COMPRA_FK on COMPRA (
   USU_USERNAME ASC
);

/*==============================================================*/
/* Index: COMPRA2_FK                                            */
/*==============================================================*/
create index COMPRA2_FK on COMPRA (
   PRO_ID ASC
);

/*==============================================================*/
/* Table: GUARDA                                                */
/*==============================================================*/
create table GUARDA 
(
   USU_USERNAME         VARCHAR2(15)         not null,
   PRO_ID               INTEGER              not null,
   constraint PK_GUARDA primary key (USU_USERNAME, PRO_ID)
);

/*==============================================================*/
/* Index: GUARDA_FK                                             */
/*==============================================================*/
create index GUARDA_FK on GUARDA (
   USU_USERNAME ASC
);

/*==============================================================*/
/* Index: GUARDA2_FK                                            */
/*==============================================================*/
create index GUARDA2_FK on GUARDA (
   PRO_ID ASC
);

/*==============================================================*/
/* Table: NOTIFICACION                                          */
/*==============================================================*/
create table NOTIFICACION 
(
   NOTI_ID              INTEGER              not null,
   USU_USERNAME         VARCHAR2(15),
   NOTI_NOMBRE          VARCHAR2(20)         not null,
   NOTI_DESCRIPCION     VARCHAR2(50)         not null,
   NOTI_VISTA           SMALLINT,
   constraint PK_NOTIFICACION primary key (NOTI_ID)
);

/*==============================================================*/
/* Index: TIENE_FK                                              */
/*==============================================================*/
create index TIENE_FK on NOTIFICACION (
   USU_USERNAME ASC
);

/*==============================================================*/
/* Table: PRODUCTO                                              */
/*==============================================================*/
create table PRODUCTO 
(
   PRO_ID               INTEGER              not null,
   USU_USERNAME         VARCHAR2(15)         not null,
   PRO_NOMBRE           VARCHAR2(100)        not null,
   PRO_PRECIO           FLOAT                not null,
   PRO_CATEGORIA        VARCHAR2(100)        not null,
   PRO_DESCRIPCION      VARCHAR2(2000),
   PRO_IMAGEN           BLOB,
   constraint PK_PRODUCTO primary key (PRO_ID)
);

/*==============================================================*/
/* Index: CREA_FK                                               */
/*==============================================================*/
create index CREA_FK on PRODUCTO (
   USU_USERNAME ASC
);

/*==============================================================*/
/* Table: PROMOCIONAL                                           */
/*==============================================================*/
create table PROMOCIONAL 
(
   PROM_ID              INTEGER              not null,
   USU_USERNAME         VARCHAR2(15),
   PROM_NOMBRE          VARCHAR2(100)        not null,
   PROM_IMAGEN          BLOB,
   constraint PK_PROMOCIONAL primary key (PROM_ID)
);

/*==============================================================*/
/* Index: CREA1_FK                                              */
/*==============================================================*/
create index CREA1_FK on PROMOCIONAL (
   USU_USERNAME ASC
);

/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO 
(
   USU_USERNAME         VARCHAR2(15)         not null,
   USU_NOMBRE           VARCHAR2(50)         not null,
   USU_PASSWORD         VARCHAR2(50)         not null,
   USU_FECHANACIMIENTO  DATE                 not null,
   USU_FOTO             BLOB,
   constraint PK_USUARIO primary key (USU_USERNAME)
);

alter table COMPRA
   add constraint FK_COMPRA_COMPRA_USUARIO foreign key (USU_USERNAME)
      references USUARIO (USU_USERNAME);

alter table COMPRA
   add constraint FK_COMPRA_COMPRA2_PRODUCTO foreign key (PRO_ID)
      references PRODUCTO (PRO_ID);

alter table GUARDA
   add constraint FK_GUARDA_GUARDA_USUARIO foreign key (USU_USERNAME)
      references USUARIO (USU_USERNAME);

alter table GUARDA
   add constraint FK_GUARDA_GUARDA2_PRODUCTO foreign key (PRO_ID)
      references PRODUCTO (PRO_ID);

alter table NOTIFICACION
   add constraint FK_NOTIFICA_TIENE_USUARIO foreign key (USU_USERNAME)
      references USUARIO (USU_USERNAME);

alter table PRODUCTO
   add constraint FK_PRODUCTO_CREA_USUARIO foreign key (USU_USERNAME)
      references USUARIO (USU_USERNAME);

alter table PROMOCIONAL
   add constraint FK_PROMOCIO_CREA1_USUARIO foreign key (USU_USERNAME)
      references USUARIO (USU_USERNAME);

