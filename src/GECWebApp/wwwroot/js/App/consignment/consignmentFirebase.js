//codigo para guardar en base de datos Fire Base

var mensaje = "";
var db;

var datosRemesas1 = new Array();
var datosRemesas2 = new Array();
var datosRemesas3 = new Array();
var datosRemesas4 = new Array();
var datosRemesas5 = new Array();
var datosRemesas6 = new Array();
var datosRemesas7 = new Array();

var colection = "Remesas";
var idRemesa = "";



function validate(cantidadBtc, montoRemesas, tasasRemesas, tasasVentasBtc) {

    if (cantidadBtc == "" || montoRemesas == "" || tasasRemesas == "" || tasasVentasBtc == "") {

        return mensaje = "Porfavor no dejar ningun recuadro vacio.";
    }
    else
    {
        return mensaje = "";
    }

}


function saveRemittances() {

    var cantidadBtc = parseFloat(document.getElementById("cantidadBtc").value);
    var montoRemesas = parseFloat(document.getElementById("montoRemesas").value);
    var tasasRemesas = parseFloat(document.getElementById("tasasRemesas").value);
    var tasasVentasBtc = parseFloat(document.getElementById("tasasVentasBtc").value);

    
    if (validate(cantidadBtc, montoRemesas, tasasRemesas, tasasVentasBtc) == "") {

        var contactoCheck = document.getElementById("contacto").checked;
        var f = new Date();
        var fechaActual = f.getDate() + "/" + (f.getMonth() + 1) + "/" + f.getFullYear();
        

        var montoTotal = (cantidadBtc * tasasVentasBtc);
        var montoEntrega = (tasasRemesas * montoRemesas);

        var gananciaEmpresa = (montoTotal - montoEntrega); // ganancia para despues dependiente del contacto

        if (contactoCheck) {

            gananciaC = (gananciaEmpresa * 0.2);
            gananciaE = (gananciaEmpresa * 0.3);
            gananciaGEC = (gananciaEmpresa * 0.5);

        } else {

            gananciaC = 0;
            gananciaE = (gananciaEmpresa * 0.4);
            gananciaGEC = (gananciaEmpresa * 0.6);

        }
        var gananciaNeta = (cantidadBtc + montoRemesas + tasasVentasBtc + tasasRemesas);

        document.getElementById("montoTotal").value = montoTotal;
        document.getElementById("gananciaC").value = gananciaC;
        document.getElementById("gananciaE").value = gananciaE;
        document.getElementById("gananciaGEC").value = gananciaGEC;
        document.getElementById("montoEntrega").value = montoEntrega; 
        document.getElementById("gananciaNeta").value = gananciaNeta;


        if (idRemesa != "") {

            updateRemittances(idRemesa);

        }
        else
        {
            addFirebase(db, colection, montoTotal, contactoCheck, gananciaC, gananciaE, gananciaGEC, montoEntrega, gananciaNeta, fechaActual);
        }


    }
    else
    {
        var msnDiv = document.getElementById("mensajeError");
        msnDiv.innerHTML = `<div class="alert alert-danger">${validate(cantidadBtc, montoRemesas, tasasRemesas, tasasVentasBtc)}</div>`
    }

    
}

function Cancelremittances() {

    document.getElementById("cantidadBtc").value = "";
    document.getElementById("montoRemesas").value = "";
    document.getElementById("tasasRemesas").value = "";
    document.getElementById("tasasVentasBtc").value = "";

    document.getElementById("montoTotal").value = "";
    document.getElementById("gananciaC").value = "";
    document.getElementById("gananciaE").value = "";
    document.getElementById("gananciaGEC").value = "";
    document.getElementById("montoEntrega").value = "";
    document.getElementById("gananciaNeta").value = "";

    msnDiv.innerHTML = "";

}

function getRemittances() {

    var tablaRemesas = document.getElementById("datosTabla");
    

    var i = 0;

    db.collection(colection).limit(5).onSnapshot((querySnapshot) => {
        tablaRemesas.innerHTML = "";

        getTable(querySnapshot, tablaRemesas, i);
        
    });

}

function updateRemittances(id) {

    var f = new Date();
    var fechaActual = f.getDate() + "/" + (f.getMonth() + 1) + "/" + f.getFullYear();
    var montoTotalDB = document.getElementById("montoTotal").value;
    var contactoCheckBD = document.getElementById("contacto").checked;
    var gananciaCBD = document.getElementById("gananciaC").value;
    var gananciaEDB = document.getElementById("gananciaE").value;
    var gananciaGECDB = document.getElementById("gananciaGEC").value;
    var montoEntregaDB = document.getElementById("montoEntrega").value;
    var gananciaNetaDB = document.getElementById("gananciaNeta").value;
    var fecha = fechaActual;

    firebaseUpdate(colection,id,montoTotalDB, contactoCheckBD, gananciaCBD, gananciaEDB, gananciaGECDB, montoEntregaDB, gananciaNetaDB, fecha);
    console.log(id);
}

function saveDataId(id, n) {

    document.getElementById("contacto").checked = datosRemesas1[n];
    document.getElementById("gananciaC").value = datosRemesas2[n];
    document.getElementById("gananciaE").value = datosRemesas3[n];
    document.getElementById("gananciaGEC").value = datosRemesas4[n];
    document.getElementById("montoEntrega").value = datosRemesas5[n];
    document.getElementById("gananciaNeta").value = datosRemesas6[n];
    document.getElementById("montoTotal").value = datosRemesas7[n];

    idRemesa = id;
}

function look() {

    var fechaF = document.getElementById("filtrofecha").checked;
    var paisF = document.getElementById("filtroPais").checked;
    var montoF = document.getElementById("filtroMonto").checked;
    var filtro = "";

    var busqueda = document.getElementById("buscaRemesa").value;
    var tablaRemesas = document.getElementById("datosTabla");
    var i = 0;

    var errorFiltro = document.getElementById("errorFiltro");
    var existeDoc = null;

    if (fechaF) {
        filtro = "fecha";
    }
    else if (paisF) {
        filtro = "pais";
    }
    else {
        filtro = "montoTotalDB"
    }


    if (filtro != "") {

        db.collection(colection).where(filtro, "==", busqueda).limit(5)
            .get()
            .then(function (querySnapshot) {
                tablaRemesas.innerHTML = "";

                

                if (getTable(querySnapshot, tablaRemesas, i) == null) {
                    errorFiltro.innerHTML = `<div class="alert alert-danger" id="errorFiltro">Ingreso algun dato Incorrecto</div>`;
                }
                else
                {
                    errorFiltro.innerHTML = `<div id="errorFiltro"></div>`;
                }

            })
            .catch(function (error) {
                console.log("Error getting documents: ", error);
            });
    }

}


