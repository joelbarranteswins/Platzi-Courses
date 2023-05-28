let userScore = 0;
let cpuScore = 0;
let closeBtn;
const userScore_span = document.getElementById("user-score");
const cpuScore_span = document.getElementById("cpu-score");
const restart = document.getElementById("restart");
const result = document.getElementById("result");
const modal = document.querySelector(".modal");
const rock_div = document.getElementById("rock");
const paper_div = document.getElementById("paper");
const scissors_div = document.getElementById("scissors");

function getCpuChoice() {
    const choices = ["rock", "paper", "scissors"];
    const randomNumber = Math.floor(Math.random() * choices.length);
    return choices[randomNumber];
}

function updateScore() {
    userScore_span.innerHTML = userScore;
    cpuScore_span.innerHTML = cpuScore;
}

function useWin(cpuChoice) {
    userScore++;
    updateScore();
    result.innerHTML = `<span class="close"></span> <h1 class="text-win">You win!</h1> <p>Computer choose <strong>${cpuChoice}</strong></p>`;
    modal.style.display = "flex";
}

function userLose(cpuChoice) {
    cpuScore++;
    updateScore();
    result.innerHTML = `<span class="close"></span> <h1 class="text-lose">You lost</h1> <p>Computer choose <strong>${cpuChoice}</strong></p>`;
    modal.style.display = "flex";
}

function draw(cpuChoice) {
    result.innerHTML = `<span class="close"></span> <h1>It's a draw</h1> <p>You both choose <strong>${cpuChoice}</strong></p>`;
    modal.style.display = "flex";
}

function play(userChoice) {
    const cpuChoice = getCpuChoice();
    switch (userChoice) {
        case cpuChoice:
            draw(cpuChoice);
            break;
        case "rock":
            cpuChoice == "scissors"? useWin(cpuChoice) : userLose(cpuChoice);
            break;
        case "paper":
            cpuChoice == "rock"? useWin(cpuChoice) : userLose(cpuChoice);
            break;
        case "scissors":
            cpuChoice == "paper"? useWin(cpuChoice) : userLose(cpuChoice);
            break;
  }
}

function main() {
  rock_div.addEventListener("click", () => play("rock"));
  paper_div.addEventListener("click", () => play("paper"));
  scissors_div.addEventListener("click", () => play("scissors"));
}

function clearModal(e) {
    closeBtn = document.querySelector(".close");

    if (e.target == modal) {
        modal.style.display = "none";
        return;
    } 
    
    closeBtn.addEventListener("click", () => {
        modal.style.display = "none";
    });
  
}

function restartGame() {
    userScore = 0;
    cpuScore = 0;
    updateScore();
}

restart.addEventListener("click", restartGame);
window.addEventListener("click", clearModal);
main();
