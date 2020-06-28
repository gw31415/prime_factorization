for (let n = 0; n < 100000; n++) {
  let arr = [];
  let temp = n
  for (let i = 2; i < Math.floor(Math.sqrt(n)) + 1; i++)
    while (!(temp % i)) {
      arr.push(i);
      temp /= i;
    }
  if (temp != 1) arr.push(temp);
  if (arr.length === 0) arr.push(n);
}
