import { Component, OnInit } from '@angular/core';

import { BookSeatsClient, BookSeatsVm, BookSeatsCommand } from '../cinemaseats-api';

interface PendingSeats {
  row: string;
  seat: string;
}

@Component({
  selector: 'app-book-seats',
  templateUrl: './book-seats.component.html',
  styleUrls: ['./book-seats.component.css']
})
export class BookSeatsComponent implements OnInit {
  vm: BookSeatsVm = undefined;
  pendingSeats: PendingSeats[] = [];
  constructor(
    private readonly bookSeatsClient: BookSeatsClient
  ) {

  }
  ngOnInit(): void {
    this.bookSeatsClient.get().subscribe(
      result => {
        this.vm = result;
      },
      error => console.error(error)
    );
  }

  seatPick() {
    this.pendingSeats = [];
    const pendingRows = this.vm.seatsMap.rows.filter(r => r.seats.some(s => s.booked && !s.bookConfirmed));
    for (const row of pendingRows) {
      const pendingSeats = row.seats.filter(s => s.booked && !s.bookConfirmed);
      for (const seat of pendingSeats) {
        this.pendingSeats.push({
          row: row.rowTitle,
          seat: seat.seatTitle
        })
      }
    }
  }

  allowBookSeats(): boolean {
    return this.vm.seatsMap.rows.some(r => r.seats.some(s => s.booked && !s.bookConfirmed));
  }

  bookSeats(): void {
    if (!this.allowBookSeats()) {
      return;
    }

    const pendingRows = this.vm.seatsMap.rows.filter(r => r.seats.some(s => s.booked && !s.bookConfirmed));
    for (const row of pendingRows) {
      const pendingSeats = row.seats.filter(s => s.booked && !s.bookConfirmed);
      for (const seat of pendingSeats) {
        seat.bookConfirmed = true;
      }
    }

    this.bookSeatsClient.update(this.vm.seatsMap.id, BookSeatsCommand.fromJS(this.vm))
      .subscribe(
          () => {
            this.pendingSeats = [];
          },
          error => console.error(error)
      );
  }
}
