const usersDataUrl = document.getElementById('usersDataUrl').dataset.url;
const usersEditUrl = document.getElementById('usersEditUrl').dataset.url;
const usersDeleteUrl = document.getElementById('usersDeleteUrl').dataset.url;
const usersDetailsUrl = document.getElementById('usersDetailsUrl').dataset.url;
fetch(usersDataUrl)
    .then(response => response.json())
    .then(usersData => {
        const usersTable = document.getElementById("usersTable");
        usersData.forEach(user => {
            const row = document.createElement("tr");
            row.innerHTML = `
          <td>${user.name}</td>
          <td>${user.email}</td>
          <td>${user.createdAt}</td>
          <td>${user.updatedAt}</td>
          <td>
                <button class="btn btn-primary" onclick="window.location.href = '${usersEditUrl}?id=${user.id}';" id="edit-button">Edit</button>
                <button class="btn btn-info" onclick="window.location.href = '${usersDetailsUrl}?id=${user.id}';" id="details-button">Details</button>
                <button class="btn btn-danger" onclick="window.location.href = '${usersDeleteUrl}?id=${user.id}';" id="delete-button">Delete</button>
          </td>
        `;
            usersTable.appendChild(row);
        });
    });