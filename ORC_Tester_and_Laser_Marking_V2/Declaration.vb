﻿Module Declaration
    Public UserLevel As Integer
    Public BtnStnVisible As Integer
    Public LoadingBarValue As Integer
    Public LoadingBarMessage As String
    Public plcTrigger As Boolean

    Public Config As New machineConfig
    Public MODBUS_ERR As Boolean = False

    Public SetCylFest As CylFest
    Public SetCyl0 As CylFest
    Public SetCyl1 As CylFest
    Public SetRotate As CylFest
    Public GetCylFest As CylFest
    Public GetAutoMan As CylFest
    Public Structure machineConfig
        Dim dbHostName As String
        Dim dbUsername As String
        Dim dbPassword As String
        Dim dbDatabase As String
    End Structure

    Public Structure CylFest
        'Cylinder
        Dim V101 As Integer
        Dim V301 As Integer
        Dim V302 As Integer
        Dim V303 As Integer
        Dim V304 As Integer
        Dim V401 As Integer
        Dim V501 As Integer
        Dim V502 As Integer
        Dim V503 As Integer
        Dim V601 As Integer
        Dim V602 As Integer
        Dim V603 As Integer


        'Festo Indicator Read
        Dim LALM As Integer
        Dim LPEND As Integer
        Dim LHEND As Integer
        Dim LSVON As Integer
        Dim LEMG As Integer
        Dim RALM As Integer
        Dim RPEND As Integer
        Dim RHEND As Integer
        Dim RSVON As Integer
        Dim REMG As Integer

        'Festo TextBox Read
        Dim LPOSITION As Integer
        Dim LSPEED As Integer
        Dim LALARM As Integer
        Dim RPOSITION As Integer
        Dim RSPEED As Integer
        Dim RALARM As Integer

        'Festo Trigger
        Dim LALMRES As Integer
        Dim LSERVO As Integer
        Dim LJOGMIN As Integer
        Dim LJOGPLUS As Integer
        Dim LHOMING As Integer
        Dim LJISL As Integer
        Dim LPWRRES As Integer
        Dim RALMRES As Integer
        Dim RSERVO As Integer
        Dim RJOGMIN As Integer
        Dim RJOGPLUS As Integer
        Dim RHOMING As Integer
        Dim RJISL As Integer
        Dim RPWRRES As Integer

        'Auto Manual Mode Status
        Dim RUNNING_MODE
    End Structure

    Public ADDR_TEST As Integer = 9090

    Public PLC_READY As Integer = 0
    Public ADDR_PLC_READY As Integer = 60200
    Public RUNNING_STATE As Integer = 0
    Public ADDR_RUNNING_STATE As Integer = 2
    Public RUNNING_MODE As Integer = 0
    Public ADDR_RUNNING_MODE As Integer = 1

    Public SCAN_MODE As Integer = 0
    Public LASER_STATE As Integer = 0

    Public ADDR_PC_STATUS As Integer = 101
    Public PC_STATUS As Integer = 0
    Public LAST_PC_STATUS As Integer = 0

    'Product Database -------------------------------------------
    Public ADDR_PUNCHING_MODE As Integer = 10000
    Public ADDR_LVL_DIST As Integer = 10002 'Punya 2 address Float
    Public ADDR_LVL_TOLER As Integer = 10003 'Punya 2 address Float
    Public ADDR_ORING As Integer = 10006
    Public ADDR_FESTO_LDIST1 As Integer = 10008 'Punya 2 address(Address 1)
    Public ADDR_FESTO_LDIST2 As Integer = 10009 'Punya 2 address(Address 2)
    Public ADDR_FESTO_RDIST1 As Integer = 10010 'Punya 2 address(Address 1)
    Public ADDR_FESTO_RDIST2 As Integer = 10011 'Punya 2 address(Address 2)
    Public ADDR_FESTO_LSPEED As Integer = 10012
    Public ADDR_FESTO_RSPEED As Integer = 10014
    Public ADDR_LASER_TEMPLATE As Integer = 10030
    Public ADDR_CAMERA_PROGRAM As Integer = 10032

    'For Cylinder  ----------------------------------------------
    Public FORWARD As Integer = 1
    Public BACKWARD As Integer = 2
    Public IDLE As Integer = 0


    Public ADDR_STN1_CYL1 As Integer = 1101
    Public ADDR_ROTARY_TABLE As Integer = 1110


    Public STN1_CYL1 As Integer = 0
    Public LAST_STN1_CYL1 As Integer = 0

    Public ADDR_STN3_CYL1 As Integer = 3101
    Public ADDR_STN3_CYL2 As Integer = 3102
    Public ADDR_STN3_CYL3 As Integer = 3103
    Public ADDR_STN3_CYL4 As Integer = 3104

    Public STN3_CYL1 As Integer = 0
    Public STN3_CYL2 As Integer = 0
    Public STN3_CYL3 As Integer = 0
    Public STN3_CYL4 As Integer = 0
    Public LAST_STN3_CYL1 As Integer = 0
    Public LAST_STN3_CYL2 As Integer = 0
    Public LAST_STN3_CYL3 As Integer = 0
    Public LAST_STN3_CYL4 As Integer = 0

    Public ADDR_STN4_CYL1 As Integer = 4101

    Public STN4_CYL1 As Integer = 0
    Public LAST_STN4_CYL1 As Integer = 0

    Public ADDR_STN5_CYL1 As Integer = 5101
    Public ADDR_STN5_CYL2 As Integer = 5102
    Public ADDR_STN5_CYL3 As Integer = 5103

    Public STN5_CYL1 As Integer = 0
    Public STN5_CYL2 As Integer = 0
    Public STN5_CYL3 As Integer = 0
    Public LAST_STN5_CYL1 As Integer = 0
    Public LAST_STN5_CYL2 As Integer = 0
    Public LAST_STN5_CYL3 As Integer = 0

    Public ADDR_STN6_CYL1 As Integer = 6101
    Public ADDR_STN6_CYL2 As Integer = 6102
    Public ADDR_STN6_CYL3 As Integer = 6103

    Public STN6_CYL1 As Integer = 0
    Public STN6_CYL2 As Integer = 0
    Public STN6_CYL3 As Integer = 0
    Public LAST_STN6_CYL1 As Integer = 0
    Public LAST_STN6_CYL2 As Integer = 0
    Public LAST_STN6_CYL3 As Integer = 0

    Public ADDR_STN1_SEN1 As Integer = 1201

    Public ADDR_STN3_SEN1 As Integer = 3201
    Public ADDR_STN3_SEN2 As Integer = 3202
    Public ADDR_STN3_SEN3 As Integer = 3203
    Public ADDR_STN3_SEN4 As Integer = 3204

    Public ADDR_STN4_SEN1 As Integer = 4201

    Public ADDR_STN5_SEN1 As Integer = 5201
    Public ADDR_STN5_SEN2 As Integer = 5202
    Public ADDR_STN5_SEN3 As Integer = 5203

    Public ADDR_STN6_SEN1 As Integer = 6201
    Public ADDR_STN6_SEN2 As Integer = 6202
    Public ADDR_STN6_SEN3 As Integer = 6203

    'For Festo  ----------------------------------------------
    Public UP As Integer = 1
    Public DOWN As Integer = 2

    'Trigger
    Public ADDR_STN3_TRIG_LFESTO = 370 '16bit
    Public ADDR_STN3_TRIG_RFESTO = 380 '16bit

    'Indicator
    Public ADDR_STN3_IND_LFESTO = 371 '16bit
    Public ADDR_STN3_IND_RFESTO = 381 '16bit

    'Data
    Public ADDR_STN3_PSTN_LFESTO = 374 '(Punya 2 address,startnya dari 374)
    Public ADDR_STN3_SPD_LFESTO = 376
    Public ADDR_STN3_ALM_LFESTO = 378

    Public ADDR_STN3_PSTN_RFESTO = 384 '(Punya 2 address,startnya dari 384)
    Public ADDR_STN3_SPD_RFESTO = 386
    Public ADDR_STN3_ALM_RFESTO = 388
End Module
