@extends('layouts.app')

@section('content')
    <div class="container">
        <h1>Contactbeheer</h1>
        <table class="table">
            <thead>
                <tr>
                    <th>Naam</th>
                    <th>E-mailadres</th>
                    <th>Bericht</th>
                    <th>Telefoonnummer</th>
                </tr>
            </thead>
            <tbody>
                @foreach ($contacts as $contact)
                    <tr>
                        <td>{{ $contact->name }}</td>
                        <td>{{ $contact->email }}</td>
                        <td>{{ $contact->message }}</td>
                        <td>{{ $contact->phone }}</td>
                    </tr>
                @endforeach
            </tbody>
        </table>
    </div>
@endsection
