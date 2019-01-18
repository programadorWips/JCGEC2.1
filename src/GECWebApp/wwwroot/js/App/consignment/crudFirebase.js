
// funcion para updatear en firebase
function firebaseUpdate(colection, id, montoT, contacto, gananciaC, gananciaE, ganaciaGEC, montoE, gananciaN, fecha) {

    db.collection(colection).doc(id).set({

        montoTotalDB: montoT,
        contactoCheckBD: contacto,
        gananciaCBD: gananciaC,
        gananciaEDB: gananciaE,
        gananciaGECDB: ganaciaGEC,
        montoEntregaDB: montoE,
        gananciaNetaDB: gananciaN,
        fecha: fecha

    })
        .then(function () {
            console.log("Document successfully written!");
            var msnDiv = document.getElementById("mensajeError");
            msnDiv.innerHTML = `<div class="alert alert-success">Se a Actualizado con EXITO la remesa.</div>`;
        })
        .catch(function (error) {
            console.error("Error writing document: ", error);
        });
}


// funcion para poner los datos en la tabla desde firebase

function getTable(querySnapshot, tablaRemesas, i) {

    var existeDoc = null;

    querySnapshot.forEach(function (doc) {
        // doc.data() is never undefined for query doc snapshots
        console.log(doc.id, " => ", doc.data());
        existeDoc = doc.id;

        tablaRemesas.innerHTML += `
                        <tr>
                          <th>${doc.data().fecha}</th>
                          <td>Venezuela</td>
                          <td>${doc.data().gananciaCBD}</td>
                          <td>${doc.data().gananciaEDB}</td>
                          <td>${doc.data().gananciaGECDB}</td>
                          <td>${doc.data().montoEntregaDB}</td>
                          <td>${doc.data().gananciaNetaDB}</td>
                          <td>${doc.data().montoTotalDB}</td>
                          <td>
                              <button type="button" class="btn btn-success" id="actualizarRemesa" name="actualizarRemesa" onclick="saveDataId('${doc.id}', ${i})">
                                <i class="cui-pencil icons font-2xl d-block mt-4"></i>
                              </button>
                          </td>
                        </tr>
                
                    `;

        datosRemesas1[i] = doc.data().contactoCheckBD;
        datosRemesas2[i] = doc.data().gananciaCBD;
        datosRemesas3[i] = doc.data().gananciaEDB;
        datosRemesas4[i] = doc.data().gananciaGECDB;
        datosRemesas5[i] = doc.data().montoEntregaDB;
        datosRemesas6[i] = doc.data().gananciaNetaDB;
        datosRemesas7[i] = doc.data().montoTotalDB;
        i++;

    });

    return existeDoc;
}

function addFirebase(db, colection, montoT, contacto, gananciaC, gananciaE, ganaciaGEC, montoE, gananciaN, fecha ) {

    db.collection(colection).add({

        montoTotalDB: montoT,
        contactoCheckBD: contacto,
        gananciaCBD: gananciaC,
        gananciaEDB: gananciaE,
        gananciaGECDB: ganaciaGEC,
        montoEntregaDB: montoE,
        gananciaNetaDB: gananciaN,
        fecha: fecha

    }).then(function (docRef) {
        console.log("Document written with ID: ", docRef.id);
        var msnDiv = document.getElementById("mensajeError");
        msnDiv.innerHTML = `<div class="alert alert-success">Se a Guardado con EXITO la remesa.</div>`
    })
        .catch(function (error) {
            console.error("Error adding document: ", error);
        });
}