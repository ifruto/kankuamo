async function guardar() {
    debugger;
    let nombres = document.getElementById("name").value;
    let apellidos = document.getElementById("apellidos").value;
    let email = document.getElementById("email").value;
    let aceptaString = document.getElementById("message").value;
    let acepta = false;

    if (aceptaString.toLowerCase() === "si") acepta = true;

    let user = {
        Nombres: nombres,
        Apellidos: apellidos,
        Correo: email,
        DeseaHabilitarServicio: acepta
    }

    const response = await fetch('http://localhost:5122/api/usuario/insert', {
        method: 'POST',
        mode: 'cors',
        cache: 'no-cache',
        credentials: 'same-origin',
        headers: { 'Content-Type': 'application/json', },
        redirect: 'follow',
        referrerPolicy: 'no-referrer',
        body: JSON.stringify(user)
    });

    if (response.ok) {
        debugger;
        document.getElementById("name").value = "";
        document.getElementById("email").value = "";
        document.getElementById("message").value = "";
    }
    else {
        debugger;
        alert("Error");
    }
}