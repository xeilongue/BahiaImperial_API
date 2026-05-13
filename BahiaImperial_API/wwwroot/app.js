const apiUrl = '/api/User';
const apiUrlAuth = '/api/Auth';

async function LoadUsers() {
    try {
        const response = await fetch(apiUrl);
        const User = await response.json();

        const tbody = document.getElementById('tablebody');
        tbody.innerHTML = '';

        User.forEach(user => {
            tbody.innerHTML +=
                `
                <tr>
                    <td>${user.cpf_Cnpj}</td>
                    <td>${user.password}</td>
                </tr>
            `
            console.log(user);
        });
    } catch (error) {
        alert("Erro ao buscar os dados.");
        console.error(error);
    }
}

async function LoginUser(event) {
    if (event) event.preventDefault();

    const user = {
        cpf_cnpj: document.getElementById("InputEmail").value,
        password: document.getElementById("InputPassword").value
    };

    try {
        const response = await fetch(apiUrlAuth + "/login", {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(user)
        });

        if (response.ok) {
            alert("Login efetuado com sucesso!");
            window.location.href = "dashboard.html";

            const data = await response.json();
            const token = data.token;
            localStorage.setItem("jwtToken", token);
        } else {
            alert("Usuário ou senha incorretos!");
        }
    } catch (erro) {
        console.error(erro);
    }
}

async function RegisterUser() {

    const newUser = {
        cpf_Cnpj: document.getElementById("InputEmailRegister").value,
        password: document.getElementById("InputPasswordRegister").value
    };

    try {
        const response = await fetch(apiUrl, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(newUser)
        });

        if (response.ok) {
            alert("Usuário cadastrado com sucesso!");
            window.location.href = "dashboard.html";
        } else {
            alert("Erro 401: Token inválido ou expirado.");
        }
    } catch (erro) {
        console.error(erro);
    }
}